using System;
/*Escrever um algoritmo que receba a altura e a largura de um retângulo e calcule
a sua área, ao final o algoritmo deve mostrar o resultado na tela.*/

namespace Atividade_1___Lista_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int b;
            int h;

            Console.WriteLine("Digite a altura ");
            h = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digita a base: ");
            b = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Valor da área do retangulo é "+(h*b));

        }
    }
}
