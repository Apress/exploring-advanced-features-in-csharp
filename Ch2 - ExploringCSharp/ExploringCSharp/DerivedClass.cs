using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExploringCSharp
{
    class DerivedClass : AbstractBaseClass
    {
        public override int PropA => _propA;

        public override int PropB => _propB;

        public override int PerformCalculationAB()
        {
            _propA += 50;
            _propB += 100;

            return _propA + _propB;
        }
    }
}
