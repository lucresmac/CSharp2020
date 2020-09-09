using Menu.DAL;
using Menu.Models;
using Menu.Util;
using System;
using System.Collections.Generic;
using System.Text;

namespace Menu.Views
{
    class CadastrarUsuario
    {
        public static void Renderizar()
        {
            //Para não dar problema na hora de listar na memoria
            Usuario c = new Usuario();
            // Colocar dados
            Console.WriteLine("==== 1 - Cadastrar Cliente =====");
            Console.WriteLine("==== Digite seu Usuario =====");
            c.Nome = Console.ReadLine();
            Console.WriteLine("==== Digite E-mail =====");
            c.Email = Console.ReadLine();

            Console.WriteLine("Usuario Cadastrado com sucesso!");

        }
     }
}
