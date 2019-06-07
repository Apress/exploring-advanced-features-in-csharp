using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using System.Drawing;
using System.Data.SqlClient;


namespace NewCSharp
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Recursive patterns
            //List<Person> personList = new List<Person>();

            //Person dirk = new Person("Dirk", 40, true);
            //Person jane = new Person("Jane", 63, false);
            //Person james = new Person("James", 51, true);
            //Person albert = new Person("Albert", 22, false);
            //Person sally = new Person("Sally", 14, false);

            //personList.Add(dirk);
            //personList.Add(jane);
            //personList.Add(james);
            //personList.Add(albert);
            //personList.Add(sally);


            //foreach (var person in personList)
            //{
            //    if (person is Person { RegisteredToVote: false, EligibleToVote: true })
            //    {
            //        WriteLine($"{person.Name} has not registered.");
            //    }
            //} 
            #endregion

            #region Ranges and Indicies
            string[] names = { "Dirk", "Jane", "James", "Albert", "Sally" };
            foreach (var name in names[1..^1])
            {
                // do something
            }
            Range range = 1..4;
            foreach (var name in names[range])
            {
                // do something
            }

            foreach (var name in names[1..4])
            {
                // do something
            }
            #endregion

            #region Switch expressions
            //Species species = new Reptile("Snake", true);
            //species.Age = 2;

            //switch (species)
            //{
            //    case Human h:
            //        WriteLine($"{h.Name} is a {nameof(Human)}");
            //        break;
            //    case Mammal m:
            //        WriteLine($"{m.Name} is a {nameof(Mammal)}");
            //        break;
            //    case Reptile r:
            //        WriteLine($"{r.Name} is a {nameof(Reptile)}");
            //        break;
            //    default:
            //        WriteLine("Species could not be determined");
            //        break;
            //}

            //var result = species switch
            //{
            //    Human h         => $"{h.Name} is a {nameof(Human)}",
            //    Mammal m        => $"{m.Name} is a {nameof(Mammal)}",
            //    Reptile r       => $"{r.Name} is a {nameof(Reptile)}",
            //    _               => "Species could not be determined"
            //};

            //var result = species switch
            //{
            //    Human h                         => $"{h.Name} is a {nameof(Human)}",
            //    Mammal m                        => $"{m.Name} is a {nameof(Mammal)}",
            //    Reptile r when r.LaysEggs       => $"{r.Name} is a {nameof(Reptile)} that lays eggs",
            //    Reptile r                       => $"{r.Name} is a {nameof(Reptile)}",
            //    _                               => "Species could not be determined"
            //};


            //var result = species switch
            //{
            //    Human h                         => $"{h.Name} is a {nameof(Human)}",
            //    Mammal m                        => $"{m.Name} is a {nameof(Mammal)}",
            //    Reptile {LaysEggs: true } r     => $"{r.Name} is a {nameof(Reptile)} that lays eggs",
            //    Reptile r                       => $"{r.Name} is a {nameof(Reptile)}",
            //    _                               => "Species could not be determined"
            //};

            //var result = species switch
            //{
            //    Human h                             => $"{h.Name} is a {nameof(Human)}",
            //    Mammal m                            => $"{m.Name} is a {nameof(Mammal)}",
            //    Reptile { LaysEggs: true } r        => $"{r.Name} is a {nameof(Reptile)} that lays eggs",
            //    Reptile { Age: var age }            => $"This {nameof(Reptile)} is {age} years old", 
            //    _                                   => "Species could not be determined"
            //};

            //var result = species switch
            //{
            //    Human h                         => $"{h.Name} is a {nameof(Human)}",
            //    Mammal m                        => $"{m.Name} is a {nameof(Mammal)}",
            //    Reptile { LaysEggs: true } r    => $"{r.Name} is a {nameof(Reptile)} that lays eggs",
            //    Reptile { Age: var age }        => $"This {nameof(Reptile)} is {age} years old",
            //    { }                             => species.ToString(),
            //    null                            => "null"
            //};

            //WriteLine(result);                                   
            #endregion

            #region Target-typed new-expressions
            //Point[] ps = { new Point(1, 4), new Point(3, 2), new Point(9, 5) };
            //Point[] ps = { new (1, 4), new (3, 2), new (9, 5) }; 
            #endregion

            #region Using declarations
            ////string tsql = "[SQL QRY]";
            ////string sqlConnStr = "[SQL Connection String]";
            ////using (var con = new SqlConnection(sqlConnStr))
            ////{
            ////    SqlCommand cmd = new SqlCommand(tsql, con);
            ////    //..
            ////}

            //string tsql = "[SQL QRY]";
            //string sqlConnStr = "[SQL Connection String]";
            //using var con = new SqlConnection(sqlConnStr);
            //SqlCommand cmd = new SqlCommand(tsql, con); 

            //WriteLine(cmd.CommandText);
            #endregion


            ReadLine();
        }
    }

    
}


public class Person
{
    public int Age { get; }
    public string Name { get; }
    public bool RegisteredToVote { get; set; }
    public bool EligibleToVote { get => Age > 18; }

    public Person(string name, int age, bool registered)
    {
        Name = name;
        Age = age;
        RegisteredToVote = registered;
    }
}


public class Human : Species
{
    public string Name { get; }
    public bool RegisteredToVote { get; set; }
    public bool EligibleToVote { get => Age > 18; }

    public Human(string name, bool registered)
    {
        Name = name;
        RegisteredToVote = registered;
    }
}

public class Mammal : Species
{
    public string Name { get; }
    public Mammal(string name)
    {
        Name = name;
    }
}

public class Reptile : Species
{
    public string Name { get; }
    public bool LaysEggs { get; }
    public Reptile(string name, bool laysEggs)
    {
        Name = name;
        LaysEggs = laysEggs;
    }
}



public class Species
{
    public int Age { get; set; }    
}