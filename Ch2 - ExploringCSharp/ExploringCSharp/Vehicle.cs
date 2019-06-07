using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExploringCSharp
{
    public abstract class Vehicle
    {
        protected int _wheelCount = 4;
        protected int _engineSize = 0;
        protected string _vinNumber = "";
        public abstract string VinNumber { get; }
        public abstract int EngineSize { get; }
        public abstract int WheelCount { get; }
    }
}
