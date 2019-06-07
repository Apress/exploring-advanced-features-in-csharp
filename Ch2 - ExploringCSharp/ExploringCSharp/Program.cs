using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;


namespace ExploringCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Abstract classes and interfaces
            //DerivedClass d = new DerivedClass();
            //WriteLine($"PropA before calculation {d.PropA}");
            //WriteLine($"PropB before calculation {d.PropB}");
            //WriteLine($"Perform calculation {d.PerformCalculationAB()}");
            //WriteLine($"PropA after calculation {d.PropA}");
            //WriteLine($"PropB after calculation {d.PropB}");


            //Car car1 = new Car("VIN12345", 2, 4);
            //Car car2 = new Car("VIN12345", 2, 4);
            //WriteLine(car1.VinNumberEqual(car2) ? "ERROR: Vin numbers equal" : "Vin numbers unique"); 
            #endregion

            #region Extension methods
            //string strInt = "123";
            //if (strInt.IsValidInt())
            //{
            //    WriteLine("Valid Integer");
            //}
            //else
            //{
            //    WriteLine("Not an Integer");
            //}

            //string strInt = "123";
            //if (strInt.IsValidInt(out int validIntValue))
            //{
            //    WriteLine($"Valid Integer is {validIntValue}");
            //}
            //else
            //{
            //    WriteLine("Not an Integer");
            //} 



            //WorkerClass worker = new WorkerClass();
            //worker.DoSomething(5);
            #endregion

            #region Generics
            ////Without Generics
            ////------------------------------------------------
            //Car car1 = new Car("123", 2, 4);
            //Car car2 = new Car("456", 3, 4);
            //Car car3 = new Car("789", 2, 4);

            //List<Car> carList = new List<Car>(new Car[] { car1, car2, car3 });

            //VehicleCarrier carrier = new VehicleCarrier(3);
            //foreach (var vehicle in carList)
            //{
            //    carrier.AddVehicle(vehicle);
            //}

            //carrier.GetAllVehicles();

            ////With Generics
            ////------------------------------------------------
            //SUV suv1 = new SUV("123", 2, 4, false);
            //SUV suv2 = new SUV("456", 3, 4, false);
            //SUV suv3 = new SUV("789", 2, 4, false);


            //List<SUV> carList = new List<SUV>(new SUV[] { suv1, suv2, suv3 });

            //VehicleCarrier<SUV> carrier = new VehicleCarrier<SUV>(3);
            //foreach (var vehicle in carList)
            //{
            //    carrier.AddVehicle(vehicle);
            //}

            //carrier.GetAllVehicles();

            //// With Generics (mixed objects)
            ////------------------------------------------------
            //SUV suv1 = new SUV("123", 2, 4, false);
            //Car car1 = new Car("456", 3, 4);
            //SUV suv3 = new SUV("789", 2, 4, false);

            //List<object> carList = new List<object>(new object[] { suv1, car1, suv3 });

            //VehicleCarrier<object> carrier = new VehicleCarrier<object>(3);
            //foreach (var vehicle in carList)
            //{
            //    carrier.AddVehicle(vehicle);
            //}

            //carrier.GetAllVehicles(); 

            //// Using DynamicCarrier
            //SUV suv1 = new SUV("123", 2, 4, false);
            //SUV suv2 = new SUV("456", 3, 4, false);
            //SUV suv3 = new SUV("789", 2, 4, false);
            //SUV suv4 = new SUV("987", 2, 4, false);
            //SUV suv5 = new SUV("654", 2, 4, false);
            //SUV suv6 = new SUV("321", 2, 4, false);
            //SUV suv7 = new SUV("101", 2, 4, false);
            //List<SUV> carList = new List<SUV>(new SUV[] { suv1, suv2, suv3, suv4, suv5, suv6, suv7 });

            //DynamicCarrier<SUV> carrier = new DynamicCarrier<SUV>();
            //foreach(var vehicle in carList)
            //{
            //    carrier.AddVehicle(vehicle);
            //}

            //carrier.GetAllVehicles();


            #endregion

            #region Nullable Type
            //// Valid code
            //int iValue = 10;
            //int? iValue2 = null;


            ////if (iValue2.HasValue)
            ////{
            ////    iValue = iValue2.Value;
            ////}
            ////else
            ////{
            ////    iValue = -1;
            ////}

            ////int iValue = iValue2 ?? -1;

            ////if (iValue2 is int value)
            ////{
            ////    iValue = value;
            ////}
            ////else
            ////{
            ////    iValue = -1;
            ////}

            //iValue = iValue2.GetValueOrDefault();

            //WriteLine($"The default value of iValue = {iValue}");

            //char? chVal = default;
            //var cVal2 = chVal.GetValueOrDefault();
            //WriteLine($"The default value of cVal2 = {cVal2}");


            //bool? blnValue = default;
            //int? iVal = default;
            //double? dblValue = default;
            //decimal? decVal = default;

            //WriteLine($"The default values are " +
            //    $"- blnValue = {blnValue.GetValueOrDefault()} " +
            //    $"- iVal = {iVal.GetValueOrDefault()} " +
            //    $"- dblValue = {dblValue.GetValueOrDefault()} " +
            //    $"- decVal = {decVal.GetValueOrDefault()}"); 
            #endregion
                       
            #region Dynamic type
            ////var sObject = "I am a string";
            ////sObject = 1;

            //dynamic dObject = "I am dynamic";
            ////WriteLine($"dObject = {dObject}");

            //dObject = 1;
            ////WriteLine($"dObject = {dObject}");

            //dObject = false;
            ////WriteLine($"dObject = {dObject}");

            //dObject = 1.1;
            ////WriteLine($"dObject = {dObject}");

            //if (dObject is int iValue)
            //{

            //}

            //switch (dObject)
            //{
            //    case int iObject:
            //        WriteLine($"dObject is an Integer {iObject}");
            //        break;
            //    case bool blnObject:
            //        WriteLine($"dObject is a bool {blnObject}");
            //        break;
            //    case string strObject:
            //        WriteLine($"dObject is an string {strObject}");
            //        break;
            //    case double dblObject:
            //        WriteLine($"dObject is a double {dblObject}");
            //        break;
            //    default:
            //        WriteLine($"dObject type can't be determined");
            //        break;
            //}

            //dynamic dObj;
            //bool blnFalse = false;
            //dObj = (dynamic)blnFalse;

            //WriteLine($"dObj = {dObj}"); 
            #endregion

            ReadLine();
        }
    }
}

