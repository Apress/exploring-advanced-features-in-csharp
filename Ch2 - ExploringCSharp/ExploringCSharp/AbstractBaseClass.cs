using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExploringCSharp
{
    abstract class AbstractBaseClass
    {
        protected int _propA = 100;
        protected int _propB = 200;
        public abstract int PropA { get; }
        public abstract int PropB { get; }
        public abstract int PerformCalculationAB();
    }
}
