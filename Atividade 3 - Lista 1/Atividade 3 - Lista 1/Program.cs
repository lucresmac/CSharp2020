using System;
/*
 Ler dois números inteiros e informar qual valor lido é o menor e qual é o maior.
 */
namespace Atividade_3___Lista_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1;
            int num2;

            Console.WriteLine("Digite primeiro numero: ");
            num1 = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Digite primeiro numero: ");
            num2 = Convert.ToInt16(Console.ReadLine());

            if (num1 > num2)
            {
                Console.WriteLine("Maior número é " + num1);
            }
            else if (num1 < num2)
            {
                Console.WriteLine("Maior número é " + num2);
            }
            else { Console.WriteLine("Os números são  " + num1 +" são iguais"); 
            }
        }
    }
}
