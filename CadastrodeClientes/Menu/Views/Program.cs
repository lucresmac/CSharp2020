using Menu.DAL;
using Menu.Models;
using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

/*
[ ] Usar MVC
Criar pasta para views e models

[x ]Mover a Lista para camada DAL/DAO ou repositorio

[ x]Criar os metodos de manipulação da lista
[ x]Separar cada case em uma nova classe de visualização
[ x]Separar o metodo de validação de CPF
[ ]Modularizar a validação do CPF
    [ ]Criar metodo para remover a formatação
    [ ]Criar metodo para validar validação do cpf
[ x]Modularizar o cadastrado do cliente

 */



namespace Menu.Views
{
    class Program
    {
        static void Main(string[] args)
        {
            int op;
            //Criar lista
            Usuario c = new Usuario();
            
            do
            {
                
                         
                // Limpar tela
                Console.Clear();
                Console.WriteLine("======================================="
                               + "\n============     MENU     ============="
                               + "\n======================================="
                               + "\n==== 1 - Cadastrar Usuario        ====="
                               + "\n==== 2 - Listar Usuario           ====="
                               + "\n==== 3 - Buscar Usuario           ====="
                               + "\n==== 4 - Remover Usuario        ====="
                               + "\n==== 5 - Alterar usuario       ====="
                               + "\n==== 0 - Sair                     ====="
                               + "\n=======================================");
                Console.WriteLine("Digite sua opção: ");
                op = Convert.ToInt16(Console.ReadLine());
                Console.Clear();

                switch (op)
                {
                    case 1:
                        CadastrarUsuario.Renderizar();
                        break;
                    case 2:
                        ListarUsuario.Renderizar();
                        break;
                    case 3:
                       
                        break;
                    case 4:
                        
                        break;
                    case 0:
                        Console.WriteLine("====       Saindo...       =====");
                        break;
                    default:
                        Console.WriteLine("Opção invalida");
                        break;
                }
                Console.WriteLine("\n==== Pressione uma tecla  =====");
                // Travar esperando opçao
                Console.ReadKey();


            } while (op != 0);
        }

        
    }
}
