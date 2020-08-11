using System;
using System.Xml.Schema;
/*
Construir um algoritmo que calcule a média aritmética de vários valores 
inteiros positivos inseridos pelo usuário.
O final da leitura acontecerá quando for lido um valor negativo. 
*/
namespace Atividade_6___Lista_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n=0;
            int i = 0;
            int total = 0;

            while (n >= 0)
            {
                Console.WriteLine("Digite número para somar na média aritmétrica: ");
                n = Convert.ToInt32(Console.ReadLine());
                if (n >= 0)
                {
                    total = total + n;
                    i++;
                }
                else { }
            }
            Console.WriteLine("A média média aritmétrica de " + total + "/" + i + "="+(total/i));
         }
    }
}
