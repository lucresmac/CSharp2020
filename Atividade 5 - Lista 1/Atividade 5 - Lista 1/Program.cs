﻿using System;
/*
 Desenvolver um algoritmo para ler o valor inteiro da idade de uma pessoa e imprimir uma das mensagens: 
se 
idade <= 13: Criança,
se idade > 13 e <= 18: Adolescente,
se idade > 18 e <= 60: Adulto
e se idade > 60: Idoso. 
 */
namespace Atividade_5___Lista_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int idade;    
            
            Console.WriteLine("Digite sua idade: ");
            idade = Convert.ToInt16(Console.ReadLine());

            if (idade <=13) {
                Console.WriteLine("Você é uma criança ");
            }
            else if (idade > 13 && idade <=18) {
                Console.WriteLine("Você é adolecente ");
            }
            else if (idade > 18 && idade <=60) {
                Console.WriteLine("Você é Adulto ");
            }
            else {
                Console.WriteLine("Você é Idoso ");
            }

        }
    }
}
