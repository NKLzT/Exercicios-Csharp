using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, soma;
            double media;
            //1 etapa entrada de dados
            Console.Write("Escreva um numero inteiro por favor: ");
            n1 = int.Parse(Console.ReadLine());
            Console.Write("Escreva outro numero inteiro para que possamos calcular a media deles: ");
            n2 = int.Parse(Console.ReadLine());
            //2 etapa Processamento de dados
            soma = n1 + n2;
            media = soma / 2;
            //3 etapa Saida de dados
            Console.WriteLine("Soma = " +soma);
            Console.WriteLine("media = " + media);



        }
    }
}
