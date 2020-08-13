using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace Menu
{
    class Program
    {
        static void Main(string[] args)
        {
            int op;
            
            //Criar lista
            Cliente c = new Cliente();
            List<Cliente> clientes = new List<Cliente>();
            do
            {
                
                         
                // Limpar tela
                Console.Clear();
                Console.WriteLine("======================================="
                               + "\n============     MENU     ============="
                               + "\n======================================="
                               + "\n==== 1 - Cadastrar Cliente        ====="
                               + "\n==== 2 - Listar Clientes          ====="
                               + "\n==== 3 - Cadastrar Vendedor       ====="
                               + "\n==== 4 - Listar Vendedores        ====="
                               + "\n==== 5 - Cadastrar Produtos       ====="
                               + "\n==== 6 - Listar Produtos          ====="
                               + "\n==== 7 - Registrar Venda          ====="
                               + "\n==== 8 - Listar Vendas            ====="
                               + "\n==== 9 - Listar Vendas p/ Cliente ====="
                               + "\n==== 0 - Sair                     ====="
                               + "\n=======================================");
                Console.WriteLine("Digite sua opção: ");
                op = Convert.ToInt16(Console.ReadLine());
                Console.Clear();

                switch (op)
                {
                    case 1:
                        //Para não dar problema na hora de listar na memoria
                        c = new Cliente();
                        // Colocar dados
                        Console.WriteLine("==== 1 - Cadastrar Cliente =====");
                        Console.WriteLine("==== Digite nome do cliente =====");
                        c.Nome = Console.ReadLine();
                        Console.WriteLine("==== Digite CPF do cliente =====");
                        c.Cpf = Console.ReadLine();

                        //verificação de cpf
                        //int teste = Convert.ToInt16(clientes); 
                        if (clientes.Count == 0)
                        {
                            clientes.Add(c);
                            Console.WriteLine("Primeiro cliente salvo com sucesso");
                        }
                        else
                        {
                            bool verific = false;
                            foreach (Cliente clienteCadastrado in clientes)
                            {
                                if (clienteCadastrado.Cpf == c.Cpf)
                                {
                                    verific = true;
                                }                              
                            }
                            if (verific)
                            {
                                Console.Clear();
                                Console.WriteLine("CPF já cadastrado , voltando ao menu");
                            }
                            else
                            {
                                Console.Clear();
                                clientes.Add(c);
                                Console.WriteLine("Cliente salvo com sucesso");
                                
                            }
                        }
                        break;
                    case 2:
                        Console.WriteLine("==== 2 - List de Clientes =====");
                        foreach (Cliente clienteCadastrado in clientes)
                        {
                            Console.WriteLine(clienteCadastrado);
                        }
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
