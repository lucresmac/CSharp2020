using Menu.DAL;
using Menu.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Menu.Views
{
    class ListarVendedor
    {
        public static void Renderizar()
        {

            Console.WriteLine("==== 4 - Lista de Vendedores =====");
            foreach (Vendedor vendedorCadastrado in VendedorDAL.Listar())
            {
                Console.WriteLine(vendedorCadastrado);
            }

        }

    }
}
