using System;
/*
 * Crie um algoritmo que permita fazer três conversões monetárias. O algoritmo
deve receber o valor em real (R$) e apresentar os valores convertidos em:
a) Dólar (1 dólar = 3,78 reais)
b) Euro (1 euro = 4,21 reais)
c) Peso argentino (1 peso argentino = 0,08 reais
*/
namespace Atividade_2___Lista_1
{
    class Program
    {
        static void Main(string[] args)
        {
            double quantidade;
            int op;

            Console.WriteLine("Digite sua quantidade de dinheiro: R$ ");
            quantidade = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Escolha sua opção para converter" +
                "\n 1 - Dólar (1 dólar = 3,78 reais)"+
                "\n 2 - Euro (1 euro = 4,21 reais)"+
                "\n 3 - Peso argentino (1 peso argentino = 0,08 reais)");
            op = Convert.ToInt16(Console.ReadLine());

            if (op == 1)
            {
                Console.WriteLine("Você tem R$ " + quantidade + " são " + (quantidade / 3.78) + " Dolares");
            }
            else if (op == 2)
            {
                Console.WriteLine("Você tem R$ " + quantidade + " são " + (quantidade / 4.21) + " Euros");
            }
            else if (op == 3)
            {
                Console.WriteLine("Você tem R$ " + quantidade + " são " + (quantidade / 0.08) + " Peso Arquetinos");
            }
            else {
                Console.WriteLine("Opção Invalida");
            }

        }
    }
}
