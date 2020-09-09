using Menu.DAL;
using Menu.Models;
using Menu.Util;
using System;
using System.Collections.Generic;
using System.Text;

namespace Menu.Views
{
    class CadastrarVendedor
    {
        public static void Renderizar()
        {
            //Para não dar problema na hora de listar na memoria
            Vendedor d = new Vendedor();
            // Colocar dados
            Console.WriteLine("==== 1 - Cadastrar Vendedor =====");
            Console.WriteLine("==== Digite o ID =====");
            d.Id = Console.ReadLine();
            Console.WriteLine("==== Digite nome do Vendedor =====");
            d.Nome = Console.ReadLine();
        }
    }
}
