using System;
/*
Os funcionários de uma empresa receberam um aumento de salário: técnicos (código = 1),
50%; gerentes (código = 2), 30%; demais funcionários (código = 3), 20%. 
Escrever um algoritmo para ler o código do cargo de um funcionário e o valor do seu salário atual, calcular 
e imprimir o novo salário após o aumento 

 */
namespace Atividade_4___Lista_1
{
    class Program
    {
        static void Main(string[] args)
        {
            double salario;
            int cod;

            Console.WriteLine("Digite seu sálario atual: R$ ");
            salario = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\n 1- Tecnicos \n 2- Gerente \n 3- Outros \n Digite seu código:");
            cod = Convert.ToInt16(Console.ReadLine());

            if (cod == 1) {
                Console.WriteLine("Seu novo salario de Tecnico é : R$ "+ (salario + (salario*0.5)));
            }
            else if (cod == 2) {
                Console.WriteLine("Seu novo salario de Gerente é : R$ " + (salario + (salario * 0.3)));
            }
            else if (cod == 3) {
                Console.WriteLine("Seu novo salario de Outros é : R$ " + (salario + (salario * 0.2)));
            }
            else {
                Console.WriteLine("Opção invalida");
            }

        }
    }
}
