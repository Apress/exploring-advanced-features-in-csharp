using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpInFocus
{
    public class TupleExample
    {
        public (string GuitarType, int StringCount) GetGuitarType()
        {
            return ("Les Paul Studio", 6);
        }
    }
}
