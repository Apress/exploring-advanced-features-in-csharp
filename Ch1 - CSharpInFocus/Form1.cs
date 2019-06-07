using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpInFocus
{
    public partial class Form1 : Form
    {
        public enum InstrumentType { guitar, cello, violin }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            #region Tuples
            /*
            TestTuple();
            InstanceTupleVariables();
            ComparingTuples(); 
            */
            #endregion

            #region Pattern matching
            /*
                PatternMatchingExample pme = new PatternMatchingExample();

                ExchangeStudent exchStudent = new ExchangeStudent(("John", "Doe", 21), UniversityCourses.Maths, DateTime.Now.AddMonths(6));
                Student student = new Student(("Mark", "Bates", 23), 12345, UniversityCourses.Chemistry);
                Lecturer lecturer = new Lecturer(("Allan", "Johnson", 35), 54321, UniversityCourses.Anatomy, DateTime.Now.AddYears(-3));
                Alumnus alumnus = new Alumnus(("Gabby", "Salinger", 26), 2017, UniversityDegree.BSc);
                Alumnus senalumnus = new Alumnus(("Frank", "Greer", 74), 1970, UniversityDegree.BSc);

                var output = "";
                output = pme.GetPersonCourse(exchStudent);
                Debug.WriteLine(output);
                output = pme.GetPersonCourse(student);
                Debug.WriteLine(output);
                output = pme.GetPersonCourse(lecturer);
                Debug.WriteLine(output);
                output = pme.GetPersonCourse(alumnus);
                Debug.WriteLine(output);
                output = pme.GetPersonCourse(senalumnus);
                Debug.WriteLine(output);

                Student nullStudent = null;
                output = pme.GetPersonCourse(nullStudent);
                Debug.WriteLine(output);
                */
            #endregion

            #region Out parameters
            //// Old code
            //string num = "123";
            //int numParsed;
            //if (int.TryParse(num, out numParsed))
            //{
            //    Debug.WriteLine($"{num} is a valid integer");
            //}
            //else
            //{
            //    Debug.WriteLine($"{num} is not a valid integer");
            //}

            // New code
            //string num = "123";            
            //if (int.TryParse(num, out int numParsed))
            //{
            //    Debug.WriteLine($"{num} is a valid integer");
            //}
            //else
            //{
            //    Debug.WriteLine($"{num} is not a valid integer");
            //}

            //// As a var
            //string num = "123";
            //if (int.TryParse(num, out var numParsed))
            //{
            //    Debug.WriteLine($"{num} is a valid integer");
            //}
            //else
            //{
            //    Debug.WriteLine($"{num} is not a valid integer");
            //}

            //// Using discards
            //string num = "123";
            //if (int.TryParse(num, out _))
            //{
            //    Debug.WriteLine($"{num} is a valid integer");
            //}
            //else
            //{
            //    Debug.WriteLine($"{num} is not a valid integer");
            //} 
            #endregion

            #region Local Functions
            /*
            Cube cube = new Cube(5);
            Pyramid pyramid = new Pyramid(5, 5, 5);
            Sphere sphere = new Sphere(5);
            Student student = new Student(("john", "doe", 22), 12345, UniversityCourses.Anatomy);

            DisplayMessage(cube);
            DisplayMessage(pyramid);
            DisplayMessage(sphere);
            DisplayMessage(student); 
            */
            #endregion

            #region Discards
            UsingDiscards(); 
            #endregion                                   
        }

        #region Local Functions
        public void DisplayMessage(object thing)
        {
            LocalFunctionExample lfe = new LocalFunctionExample(thing);
            Debug.WriteLine($"This is a {lfe.ObjectType} with a volume of {lfe.ObjectVolume}");
        } 
        #endregion

        #region Tuple Examples
        private void TestTuple()
        {
            TupleExample te = new TupleExample();
            //(string BrandType, int GuitarStringCount) = te.GetGuitarType();
            //var (BrandType, GuitarStringCount) = te.GetGuitarType();
            (string BrandType, var GuitarStringCount) = te.GetGuitarType();

            Debug.WriteLine(BrandType);
            Debug.WriteLine(GuitarStringCount);

            DeconstructingTuplesExplicit();
            DeconstructingTuplesInferring();
            DeconstructingTuplesIndividualInference();
            DeconstructingTuplesIndividualInference();
            DeconstructingTuplesPrevVariables();
        }

        private void InstanceTupleVariables()
        {
            string instrumentType = nameof(InstrumentType.guitar);
            int strings = 12;
            (string TypeOfInstrument, int NumberOfStrings) instrument = (instrumentType, strings);
            PlayInstrument(instrument);
        }

        private void PlayInstrument((string instrument, int strings) instrumentToPlay)
        {
            Debug.WriteLine($"I am playing a {instrumentToPlay.instrument} with {instrumentToPlay.strings} strings");
        }

        private void ComparingTuples()
        {
            string instrumentType1 = nameof(InstrumentType.guitar);
            int stringsCount1 = 6;
            (string TypeOfInstrument, int NumberOfStrings) instrument1 = (instrumentType1, stringsCount1);

            string instrumentType2 = nameof(InstrumentType.violin);
            int stringsCount2 = 4;
            (string TypeOfInstrument, int NumberOfStrings) instrument2 = (instrumentType2, stringsCount2);

            if (instrument1.NumberOfStrings != instrument2.NumberOfStrings)
            {
                Debug.WriteLine($"A {instrument2.TypeOfInstrument} does not have the same number of strings as a {instrument1.TypeOfInstrument}");
            }

            if (!instrument1.Equals(instrument2))
            {
                Debug.WriteLine("We are dealing with different instruments here.");
            }


            if (instrument1 != instrument2)
            {

            }

        }

        private void InferredTupleElementNames()
        {
            string instrumentType = nameof(InstrumentType.guitar);
            int stringsCount = 6;
            var instrument = (instrumentType, stringsCount);
        }


        private void DeconstructingTuplesExplicit()
        {
            // Explicitly declare each field's type
            TupleExample te = new TupleExample();
            (string BrandType, int GuitarStringCount) = te.GetGuitarType(); 
        }
        private void DeconstructingTuplesInferring()
        {
            // Inferring the type of each variable with the var keyword
            TupleExample te = new TupleExample();
            var (BrandType, GuitarStringCount) = te.GetGuitarType();
        }
        private void DeconstructingTuplesIndividualInference()
        {
            // Inferring the type of each variable individually with the var keyword
            TupleExample te = new TupleExample();
            (string BrandType, var GuitarStringCount) = te.GetGuitarType();
        }
        private void DeconstructingTuplesPrevVariables()
        {
            // Deconstruct into previously declared variables
            TupleExample te = new TupleExample();            
            string BrandType = "";
            int GuitarStringCount = 6;
            (BrandType, GuitarStringCount) = te.GetGuitarType();
        }




        #endregion


        /*
        // Explicitly declare each field's type
            TupleExample te = new TupleExample();
            //(string BrandType, int GuitarStringCount) = te.GetGuitarType();

            //// Inferring the type of each variable with the var keyword
            //var (BrandType, GuitarStringCount) = te.GetGuitarType();
            //(string BrandType, var GuitarStringCount) = te.GetGuitarType();

            // Deconstruct into previously declared variables
            string BrandType = "";
            int GuitarStringCount = 6;
            (BrandType, GuitarStringCount) = te.GetGuitarType();
        */

        #region Using discards
        private void UsingDiscards()
        {
            //// Local function
            //(bool zeroCheck, bool maxCheck, bool inRangeCheck) DoSomething(int value)
            //{
            //    bool blnAboveZero = false;
            //    bool blnBelowTwenty = false;
            //    bool blnInRange = false;
            //    if (value > 0)
            //        blnAboveZero = true;
            //    if (value <= 20)
            //        blnBelowTwenty = true;
            //    if (blnAboveZero && blnBelowTwenty)
            //        blnInRange = true;
            //    return (blnAboveZero, blnBelowTwenty, blnInRange);
            //}
            //// Tuple deconstruction
            //var (isZero, isNotmax, inRange) = DoSomething(21);
            //// Tuple deconstruction using discards
            //var (_, _, blnValid) = DoSomething(15);


            //// Out parameters
            //if (bool.TryParse("true", out _))
            //    Debug.WriteLine("The string value is a valid boolean");
            //else
            //    Debug.WriteLine("The string value is not a valid boolean");


            //// Standalone discard
            //_ = ExecuteCommand("[UPDATE table SQL]", "[sql connection string here]");
            //// is essentailly the same as
            //ExecuteCommand("[UPDATE table SQL]", "[sql connection string here]");
                       

            // Standalone discard
            _ = ExecuteCommand("[UPDATE table SQL]", "[sql connection string here]");
            //// This line will not compile because _ is an unassigned variable, it's a discard variable
            //Debug.WriteLine($"Checks complete. The discard value is {_}");
        }

        private int ExecuteCommand(string sql, string sqlConnectionString)
        {
            using (SqlConnection conn = new SqlConnection(sqlConnectionString))
            {
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Connection.Open();
                return cmd.ExecuteNonQuery();
            }
        } 
        #endregion
    }


    #region Throw Expressions
    public class Square
    {
        public int Side { get; }
        public string Description { get; }
        public Square(int side, string description)
        {
            Side = side;
            Description = description ?? throw new ArgumentNullException(nameof(description));
        }
    }

    public class Rectangle
    {
        public string Description { get; set; }
        public Rectangle(string description) => Description = description ?? throw new ArgumentNullException(nameof(description));
    } 
    #endregion

}
