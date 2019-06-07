using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExploringCSharp
{
    public static class ExtensionMethods
    {
        public static bool IsValidInt(this String value)
        {
            bool blnValidInt = false;
            if (int.TryParse(value, out int result))
            {
                blnValidInt = true;
            }
            return blnValidInt;
        }

        public static bool IsValidInt(this String value, out int integerValue)
        {
            bool blnValidInt = false;
            integerValue = 0;
            if (int.TryParse(value, out int result))
            {
                blnValidInt = true;
                integerValue = result;
            }
            return blnValidInt;
        }

        public static void DoSomething(this WorkerClass value, int iValue)
        {
            Console.WriteLine($"I am an extension method with parameter {iValue}");
        }
    }
}
