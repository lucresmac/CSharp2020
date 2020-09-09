using Menu.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Menu.DAL
{
    class VendedorDAL
    {


        private static List<Vendedor> vendedores = new List<Vendedor>();

        //listar vendedor
        public static List<Vendedor> Listar()
        {
            return vendedores;
        }
        //cadastrar vendedor
        public static bool Cadastrar(Vendedor d)
        {
            vendedores.Add(d);
            return true;

            /*if (BuscarVendedor(d.Id) == null)
            {
                vendedores.Add(d);
                return true;
            }
            return false;
            */
        }
        //buscar
        public static Vendedor BuscarVendedor(string Id)
        {
            foreach (Vendedor vendedoresCadastrados in vendedores)
            {
                if (vendedoresCadastrados.Id == Id)
                {
                    return vendedoresCadastrados;
                }
            }
            return null;
        }

    }
}
