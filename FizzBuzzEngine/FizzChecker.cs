using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    public class FizzChecker : IFizzChecker
    {
        public bool FizzNumber(int Number)
        {
            if (Number % 3 == 0) { return true; }
            else return false;
        }
    }
}
 