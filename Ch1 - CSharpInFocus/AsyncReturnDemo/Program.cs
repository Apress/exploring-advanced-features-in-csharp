using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace AsyncReturnDemo
{
    class Program
    {               
        static void Main(string[] args)
        {
            var shareListing = new ShareService();
            for (int i = 0; i < 100_000_000; i++)
            {
                var result = shareListing.GetStockDetails().Result;
            }

            WriteLine($"Garbage collection occurred {GC.CollectionCount(0)} times");

            //// Using discard variables
            //DoSomethingAsync(5, 1).Wait();

            ReadLine();
        }

        #region Using discard variables
        public static async Task DoSomethingAsync(int valueA, int valueB)
        {
            WriteLine("Async started at: " + DateTime.Now);
            _ = Task.Run(() => valueA + valueB);

            await Task.Delay(5000);
            WriteLine("Async completed at: " + DateTime.Now);
        } 
        #endregion
    }


    public class StockListing
    {
        public string NASDAQTickerSymbol { get; }
        public decimal Open { get; }
        public decimal High { get; }
        public decimal Low { get; }
        public string MarketCap { get; }
        public StockListing(string nasdaq, decimal open, decimal high, decimal low, string marketCap)
        {
            NASDAQTickerSymbol = nasdaq;
            Open = open;
            High = high;
            Low = low;
            MarketCap = marketCap;
        }
    }

    //public class ShareService
    //{
    //    private readonly TimeSpan cacheTime = TimeSpan.FromSeconds(2);
    //    private DateTime lastRun = DateTime.Now;
    //    private IEnumerable<StockListing> cachedListings;

    //    public async Task<IEnumerable<StockListing>> GetStockDetails()
    //    {
    //        async Task<IEnumerable<StockListing>> GetShareDetails()
    //        {
    //            cachedListings = await Task.Run(() => new List<StockListing>
    //            {
    //                new StockListing("AAPL", 157.50m, 158.52m, 154.55m, "741,37B")
    //                ,new StockListing("AMZN", 1473.35m, 1513.47m, 1449.00m, "722,71B")
    //                ,new StockListing("QCOM", 56.33m, 57.53m, 56.24m, "68,86B")
    //            });

    //            lastRun = DateTime.Now;
    //            WriteLine($"Get share details - {lastRun}");
    //            return cachedListings;
    //        }


    //        if (DateTime.Now - lastRun < cacheTime)
    //        {
    //            return cachedListings;
    //        }

    //        return await GetShareDetails();
    //    }
    //}


    public class ShareService
    {
        private readonly TimeSpan cacheTime = TimeSpan.FromSeconds(2);
        private DateTime lastRun = DateTime.Now;
        private IEnumerable<StockListing> cachedListings;

        public ValueTask<IEnumerable<StockListing>> GetStockDetails()
        {
            async Task<IEnumerable<StockListing>> GetShareDetails()
            {
                cachedListings = await Task.Run(() => new List<StockListing>
                {
                    new StockListing("AAPL", 157.50m, 158.52m, 154.55m, "741,37B")
                    ,new StockListing("AMZN", 1473.35m, 1513.47m, 1449.00m, "722,71B")
                    ,new StockListing("QCOM", 56.33m, 57.53m, 56.24m, "68,86B")
                });

                lastRun = DateTime.Now;
                WriteLine($"Get share details - {lastRun}");
                return cachedListings;
            }


            if (DateTime.Now - lastRun < cacheTime)
            {
                return new ValueTask<IEnumerable<StockListing>>(cachedListings);
            }

            return new ValueTask<IEnumerable<StockListing>>(GetShareDetails());
        }
    }




    
}
