using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tuples
{
    class Program
    {
        static void Main(string[] args)
        {
            var letters = ("a", "b");

            (string Alpha, string Beta) namedLetters = ("a", "b");

            var alphaStart = (Alpha: "a", Beta: "b");

            var range = Range(new int[] { 1,2,3});

            (int max, int min) = Range(new int[] { 1, 2, 3 });


        }

        private static (int Max, int Min) Range(IEnumerable<int> Numbers)
        {
            int min = int.MaxValue;
            int max = int.MinValue;
            foreach (var n in Numbers)
            {
                min = (n < min) ? n : min;
                max = (n > max) ? n : max;
            }
            return (max, min);
        }
    }
}
