using static System.Console;

namespace vscodedemo
{
    public class Program
    {
        static void Main(string[] args)
        {
            //var lstWidgets =
            //    new List<string>()
            //    { "widget1", "widget2", "widget3" };

            //foreach (var widget in lstWidgets
            //    .Where(widget => widget.EndsWith("2"))
            //    .Select(widget => widget))
            //{
            //    WriteLine($"{widget} exists in the list");
            //}


            //// Example of using let
            //var lstStockCode =
            //    new List<string>()
            //    { "A100-341", "B101-754", "A100-197", "C201-341", "B102-774", "C101-111", "A100-774", "C105-191" };

            //var classAStockCodes =
            //    from aclass in lstStockCode
            //    let a = (aclass.StartsWith("A100") ? (aclass.Replace("A100-", "")) : "0")
            //    where Convert.ToInt32(a) > 200
            //    && Convert.ToInt32(a) > 0
            //    select aclass;

            //foreach (var cl in classAStockCodes)
            //{
            //    WriteLine($"{cl} is a class A stock code in the 200 plus range");
            //}

            //var FirstName = "Dirk";
            //var LastName = "Strauss";
            //var FullName = $"My name is {FirstName} {LastName}";

            //NotSuchNiceCode();


            //var logger = new LoggerClass(
            //    "start"
            //    , 10
            //    , "verbose");

            //logger.AddLogEntry();



            #region IntelliCode Demo
            //var fullName = "";
            //string[] fnSplit;

            //Human.PrintPersonInfo("Jonah", "Macrel", 42);
            //fullName = Human.FullName(Human.NameOrder.FirstLast);
            //fnSplit = fullName.Split(' ');
            //WriteLine(fnSplit[0]);

            //Human.PrintPersonInfo("Sally", "Johnson", 32);
            //fullName = Human.FullName(Human.NameOrder.FirstLast);
            //fnSplit = fullName.Split(' ');
            //WriteLine(fnSplit[0]);

            //Human.PrintPersonInfo("Larry", "Leisure", 27);
            //fullName = Human.FullName(Human.NameOrder.FirstLast);
            #endregion

            #region C# Interactive Demo
            var someText = "The rain falls mainly on the plain in Spain";
            var arrWords = someText.Split(' ');
            var newText = "";
            foreach (var word in arrWords)
            {
                var textToAppend = word.Equals("mainly") ? "gently" : word;
                newText += word; // The bug
            }

            WriteLine(newText);
            #endregion
            
            ReadLine();

        }

        public static void PrintDate(string date) => WriteLine($"The date is {date}");

        public static void NotSuchNiceCode()
        {
            ZeroValue(out var iValue);
            WriteLine($"The variable changed to: {iValue}");
        }

        public static void ZeroValue(out int iValue) => iValue = 0;
    }

    internal class LoggerClass
    {
        public string Flag { get; }
        public int Priority { get; }
        public string LogLevel { get; }


        public LoggerClass(string flag,
                           int priority,
                           string logLevel)
        {
            Flag = flag;
            Priority = priority;
            LogLevel = logLevel;
        }


        public void AddLogEntry()
        {
            var iLogLevel = DetermineLogLevelPriority();
            Log(iLogLevel, Priority, Flag);
        }


        private int DetermineLogLevelPriority() => LogLevel.ToLower() switch
        {
            "verbose" => 10,
            "info" => 5,
            "minimal" => 1,
            _ => 0
        };

        public override bool Equals(object obj) => obj is LoggerClass other &&
                   Flag == other.Flag &&
                   Priority == other.Priority &&
                   LogLevel == other.LogLevel;

        public override int GetHashCode()
        {
            var hashCode = -1332235279;
            hashCode = hashCode * -1521134295 + System.Collections.Generic.EqualityComparer<string>.Default.GetHashCode(Flag);
            hashCode = hashCode * -1521134295 + Priority.GetHashCode();
            hashCode = hashCode * -1521134295 + System.Collections.Generic.EqualityComparer<string>.Default.GetHashCode(LogLevel);
            return hashCode;
        }

        internal void Log(int logLevel, int priority, string flag) => WriteLine($"LogLevel = {logLevel} \nPriority = {priority} \nFlag = {flag}");
    }
}



/*
<restaurant>
  <food>
    <name>Hamburger</name>
    <price>$5.95</price>
    <description>160g patty</description>
    <calories>875</calories>
  </food>  
  <food>
    <name>Farmhouse Breakfast</name>
    <price>$6.95</price>
    <description>Two eggs, bacon or sausage, toast, and hash brown. Bottomless coffee</description>
    <calories>820</calories>
  </food>
</restaurant>

*/
