using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator.lib
{
    public class NumberAttributter
    {
        public static bool IsPrime(int number)
        {
            if (number < 2) return false;
            if (number == 2) return true;
            if (number == 3) return true;
            if (number % 2 == 0) return false;
            if (number % 3 == 0) return false;
            return true;
        }
    }
}
