using Menu.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Menu.DAL
{
    class UsuarioDAL
    {

        private static List<Usuario> usuarios = new List<Usuario>();
        
        //listar cliente
        public static List<Usuario> Listar()
        {
            return usuarios;
        }
        //cadastrar cliente
        /*
        public static bool Cadastrar(Usuario c)
        {
            if (BuscarCliente(c.Cpf) == null)
            {
                clientes.Add(c);
                return true;
            }
            return false;

        }
        //buscar
        public static Usuario BuscarCliente(string cpf)
        {
            foreach (Usuario clienteCadastrado in clientes)
            {
                if (clienteCadastrado.Cpf == cpf)
                {
                    return clienteCadastrado;
                }
            }
            return null;
        }
        */
    }
}
