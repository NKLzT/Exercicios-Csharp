using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funções_e_procedimentos
{
    internal class Program
    {
        static void Troca(ref int x, ref int y )
        {
            int a = 5, b = 7;
            //passagem de parametros por referencia
            Console.WriteLine($"antes da troca: x {x} e y {y}");
            int temp = x;
            y = temp;
            Console.WriteLine($"Apos a troca: x = {x} e y {y}");
            

        }
    }
}
