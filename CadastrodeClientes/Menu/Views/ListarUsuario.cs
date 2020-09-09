using Menu.DAL;
using Menu.Models;
using System;

namespace Menu.Views
{
    class ListarUsuario
    {
        public static void Renderizar()
        {

        Console.WriteLine("==== 2 - List de Usuarios =====");
            foreach (Usuario usuariosCadastrado in UsuarioDAL.Listar())
            {
                Console.WriteLine(usuariosCadastrado);
            }
           
        } 
     }
}
        
                        
     



    
