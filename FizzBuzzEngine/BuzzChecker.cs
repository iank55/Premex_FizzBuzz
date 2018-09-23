using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    public class BuzzChecker : IBuzzChecker
    {
        public bool BuzzNumber(int Number)
        {
            if (Number % 5 == 0) { return true; }
            else return false;
        }
    }
}
