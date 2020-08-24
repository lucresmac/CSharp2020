using Menu.DAL;
using Menu.Models;
using System;

namespace Menu.Views
{
    class ListarClientes
    {
        public static void Renderizar()
        {

        Console.WriteLine("==== 2 - List de Clientes =====");
            foreach (Cliente clienteCadastrado in ClienteDAL.Listar())
            {
                Console.WriteLine(clienteCadastrado);
            }
           
        } 
     }
}
        
                        
     



    
