using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace __
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int preinc = 7 ,posinc = 7, predec = 7, posdec = 7; ;
            Console.WriteLine($"preinc = {++preinc}");
            Console.WriteLine($"posinc = {posinc++}");
            Console.WriteLine($"predec = {--predec}");
            Console.WriteLine($"posdec = {posdec--}");
            //REIMPRIMINDO  
            Console.WriteLine("\nREIMPRIMINDO");
            Console.WriteLine(preinc);
            Console.WriteLine(posinc);
            Console.WriteLine(predec);
            Console.WriteLine(posdec);
        }
    }
}
