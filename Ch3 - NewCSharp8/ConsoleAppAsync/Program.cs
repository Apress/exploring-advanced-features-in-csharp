using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ConsoleAppAsync
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var result = await GetSomethingAsync();

            WriteLine(result);
            ReadLine();
        }

        static async Task<int> GetSomethingAsync()
        {
            await Task.Delay(1000);
            return 0;
        }

        //static IAsyncEnumerable<int> GetLotsAsync()
        //{
        //    await foreach(var item in GetSomethingAsync())
        //    {
        //        if (item > 8)
        //            yield return item;
        //    }
        //}


        //static async Task<List<int>> GetSomethingAsync()
        //{
        //    await Task.Delay(1000);
        //    return new List<int>() { 1, 3, 5, 7, 9, 8, 6, 4, 2 };
        //}
    }
}
