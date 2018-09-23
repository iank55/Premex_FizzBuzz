using FizzBuzz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzEngine
{
    public class FizzBuzzEngine
    {
        public String ConvertToFizzBuzz(int input)
        {
            IFizzChecker fizzChecker;
            fizzChecker = new FizzChecker();

            IBuzzChecker buzzChecker;
            buzzChecker = new BuzzChecker();

            if (fizzChecker.FizzNumber(input) && buzzChecker.BuzzNumber(input)) { return "FizzBuzz"; }
            else if (fizzChecker.FizzNumber(input)) { return "Fizz"; }
            else if (buzzChecker.BuzzNumber(input)) { return "Buzz"; }
            else { return input.ToString(); }
        }
    }
}
