using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExploringCSharp
{
    //public class VehicleCarrier
    //{
    //    private Car[] _loadbay;
    //    private int _capacity;

    //    public VehicleCarrier(int capacity)
    //    {
    //        _loadbay = new Car[capacity];
    //        _capacity = capacity;
    //    }

    //    public void AddVehicle(Car vehicle)
    //    {
    //        var loaded = _loadbay.Where(x => x != null).Count();
    //        if (loaded == _capacity)
    //        {
    //            Console.WriteLine($"Vehicle Carrier filled to capacity {_capacity}.");
    //        }
    //        else
    //        {
    //            _loadbay[loaded] = vehicle;
    //        }
    //    }

    //    public void GetAllVehicles()
    //    {
    //        foreach (Car vehicle in _loadbay)
    //        {
    //            Console.WriteLine($"Vehicle with VIN number {vehicle.VinNumber} loaded");
    //        }
    //    }
    //}


    public class DynamicCarrier<T> : ICarrier<T>
    {
        private List<T> _loadbay;
        public DynamicCarrier()
        {
            _loadbay = new List<T>();
        }

        public void AddVehicle(T vehicle)
        {
            _loadbay.Add(vehicle);
        }

        public void GetAllVehicles()
        {
            foreach (T vehicle in _loadbay)
            {
                switch (vehicle)
                {
                    case Car car:
                        Console.WriteLine($"{car.GetType().Name} with VIN number {car.VinNumber} loaded");
                        break;
                    case SUV suv:
                        Console.WriteLine($"{suv.GetType().Name} with VIN number {suv.VinNumber} loaded");
                        break;
                    default:
                        Console.WriteLine($"Vehicle not determined");
                        break;
                }
            }
        }

    }

    public class VehicleCarrier<T> : ICarrier<T>
    {
        private T[] _loadbay;
        private int _capacity;

        public VehicleCarrier(int capacity)
        {
            _loadbay = new T[capacity];
            _capacity = capacity;
        }

        public void AddVehicle(T vehicle)
        {
            var loaded = _loadbay.Where(x => x != null).Count();
            if (loaded == _capacity)
            {
                Console.WriteLine($"Vehicle Carrier filled to capacity {_capacity}.");
            }
            else
            {
                _loadbay[loaded] = vehicle;
            }
        }

        public void GetAllVehicles()
        {
            foreach (T vehicle in _loadbay)
            {
                switch (vehicle)
                {
                    case Car car:
                        Console.WriteLine($"{car.GetType().Name} with VIN number {car.VinNumber} loaded");
                        break;
                    case SUV suv:
                        Console.WriteLine($"{suv.GetType().Name} with VIN number {suv.VinNumber} loaded");
                        break;
                    default:
                        Console.WriteLine($"Vehicle not determined");
                        break;
                }
            }
        }
    }

        
}
