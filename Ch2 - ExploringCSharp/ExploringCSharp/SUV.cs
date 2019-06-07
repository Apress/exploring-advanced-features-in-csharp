using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExploringCSharp
{
    class SUV : Vehicle, IComparable<SUV>, IDiffLockable
    {
        public override string VinNumber => _vinNumber;

        public override int EngineSize => _engineSize;

        public override int WheelCount => _wheelCount;

        public bool AutomaticDiff { get; } = false;

        public SUV(string vinNumber, int engineSize, int wheelCount, bool autoDiff)
        {
            _vinNumber = vinNumber;
            _engineSize = engineSize;
            _wheelCount = wheelCount;
            AutomaticDiff = autoDiff;
        }

        public bool VinNumberEqual(SUV suv)
        {
            return VinNumber.Equals(suv.VinNumber);
        }
    }
}
