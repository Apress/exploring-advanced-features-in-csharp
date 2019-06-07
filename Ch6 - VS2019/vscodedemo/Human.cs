using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vscodedemo
{
    public static class Human
    {
        public enum NameOrder { FirstLast, LastFirst }
        public static string FirstName { get; set; }
        public static string LastName { get; set; }
        public static int Age { get; set; }
        public static void PrintPersonInfo(string firstName, string lastName, int age)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            Console.WriteLine($"{firstName} {lastName} is {age} years old");
        }

        public static string FullName(NameOrder nameorder)
        {
            return nameorder switch
            {
                NameOrder.FirstLast => $"{FirstName} {LastName}",
                NameOrder.LastFirst => $"{LastName} {FirstName}",
                _                   => $"{FirstName} {LastName}"
            };
        }
    }
}
