using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INSS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double salario;
            double inss;

            Console.WriteLine("Qual o valor total do seu salario");
            salario = float.Parse(Console.ReadLine());
            double v = salario * 0.11;
            inss = v;
            Console.WriteLine($"O valor do inss do seu salario e {v} ");
        }
    }
}
