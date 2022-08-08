using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ifs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double salario, inss,inss2;

            Console.WriteLine("Qual seu salario?");
            salario = double.Parse(Console.ReadLine());

            if (salario <= 1000)
            {
                inss = salario * 0.08;
                ;
            }
            else
                if (salario <= 1800)
            {
                inss = salario * 0.10;
            }
            else
                inss = salario * 0.12;
            Console.WriteLine($"Voce paga {inss} de aliquota");
            
        }
    }
}
