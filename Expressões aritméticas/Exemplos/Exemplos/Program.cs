using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int soma;
            int N1, N2, N3, N4, N5;
            double media;
            Console.WriteLine("Digite o Valor assosiado ao numero 1");
            N1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o Valor assosiado ao numero 2");
            N2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o Valor assosiado ao numero 3");
            N3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o Valor assosiado ao numero 4");
            N4 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o Valor assosiado ao numero 5");
            N5 = int.Parse(Console.ReadLine());
            soma = N1 + N2 + N3 + N4 + N5;
            media = soma / 5.0;
            Console.WriteLine("A media dos valores obtidos é:  " +media);
;            
        }
    }
}
