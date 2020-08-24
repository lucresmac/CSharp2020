using Menu.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Menu.DAL
{
    class ClienteDAL
    {

        private static List<Cliente> clientes = new List<Cliente>();
        
        //listar cliente
        public static List<Cliente> Listar()
        {
            return clientes;
        }
        //cadastrar cliente
        public static bool Cadastrar(Cliente c)
        {
            if (BuscarCliente(c.Cpf) == null)
            {
                clientes.Add(c);
                return true;
            }
            return false;

        }
        //buscar
        public static Cliente BuscarCliente(string cpf)
        {
            foreach (Cliente clienteCadastrado in clientes)
            {
                if (clienteCadastrado.Cpf == cpf)
                {
                    return clienteCadastrado;
                }
            }
            return null;
        }
    }
}
