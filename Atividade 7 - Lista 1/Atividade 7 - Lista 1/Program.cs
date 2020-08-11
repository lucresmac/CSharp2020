using System;
/*
 Criar um algoritmo que leia um valor positivo inteiro e imprima a sequência Fibonacci 
até o valor lido. Por exemplo: caso o usuário insira o número 15, 
o programa deve imprimir na tela os números 0, 1, 1, 2, 3, 5, 8, 13. 
 */
namespace Atividade_7___Lista_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int seq;
            int n1 = 1;
            int n2 = 1;
            int result = 0;
            Console.WriteLine("Digite número para fazer sequencia de fibonacci: ");
            seq = Convert.ToInt16(Console.ReadLine());

            for (int i = 0; i < seq; i++)
            {
                /*
                 Fn = Fn - 1 + Fn - 2
                0, 1, 1, 2, 3, 5, 8, 13. 
                 */

                if (i == 0)
                {
                    Console.WriteLine("\t0");
                }
                else if (i == 1)
                {
                    Console.WriteLine("\t1");
                }
                else if (i == 2)
                {
                    Console.WriteLine("\t1");
                }

                else
                {
                    result = n1 + n2;
                    Console.WriteLine("\t"+result);
                    n2 = n1;
                    n1 = result;
                }
            }
        }
    }
}
