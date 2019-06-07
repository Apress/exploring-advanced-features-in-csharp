using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace vscodewebdemo.helpers
{
    public static class ext
    {








        public static int ToInt(this string value)
        {
            return Int32.TryParse(value, out var parsedVal) ? parsedVal : 0;
        }
    }
}