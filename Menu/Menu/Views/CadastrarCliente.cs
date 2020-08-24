using Menu.DAL;
using Menu.Models;
using Menu.Util;
using System;
using System.Collections.Generic;
using System.Text;

namespace Menu.Views
{
    class CadastrarCliente
    {
        public static void Renderizar()
        {
            //Para não dar problema na hora de listar na memoria
            Cliente c = new Cliente();
            // Colocar dados
            Console.WriteLine("==== 1 - Cadastrar Cliente =====");
            Console.WriteLine("==== Digite nome do cliente =====");
            c.Nome = Console.ReadLine();
            Console.WriteLine("==== Digite CPF do cliente =====");
            c.Cpf = Console.ReadLine();

            //verificação de cpf
            if (Validacao.ValidarCpf(c.Cpf))
            {
                if (ClienteDAL.Cadastrar(c)) //for verdadeiro
                {
                    Console.WriteLine("Cliente Cadastrado com sucesso!");
                }
                else
                {
                    Console.WriteLine("Esse cliente já existe");
                }
            }
            else
            {
                Console.WriteLine("CPF invalido , voltando ao menu");
            }
        }
     }
}
