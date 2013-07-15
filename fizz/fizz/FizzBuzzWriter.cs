using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fizz
{
    class FizzBuzzWriter
    {
        public static void WriteToConsole()
        {
            Enumerable.Range(1, 100).ToList<int>().ForEach(n => Console.WriteLine(
                (n % 3 == 0 && n % 5 == 0) ? "FizzBuzz" :
                (n % 3 == 0) ? "Buzz" :
                (n % 5 == 0) ? "Fizz" :
                n.ToString()));
        }
    }
}
