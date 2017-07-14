using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp7POC
{
    class Program
    {
        static void Main(string[] args)
        {
            if (int.TryParse(Console.ReadLine(), out var answer))
                Console.WriteLine(answer);
            else
                Console.WriteLine("Could not parse input");
            Console.Read();
        }
    }
}
