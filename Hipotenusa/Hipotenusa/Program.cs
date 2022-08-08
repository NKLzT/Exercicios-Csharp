using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hipotenusa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Double  cateto1, cateto2 , hipotenusa;
             ;

                Console.WriteLine("Digite o Valor assosiado ao primeiro cateto");
                cateto1 = Double.Parse(Console.ReadLine());

                Console.WriteLine("Digite o Valor assosiado ao primeiro cateto");
                cateto2 = Double.Parse(Console.ReadLine());

            hipotenusa = Math.Sqrt(Math.Pow(cateto1, 2) + Math.Pow(cateto2, 2));
            Console.WriteLine("A hipotenusa dos valorores assosiados é: " +hipotenusa);

        }
    }
}
