using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace For_While
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, d;
            a = 5;
            b = 10;
            int x = (a < 10? a++ + b : ++b - a);
            Console.WriteLine(x);
        }
    }
}
