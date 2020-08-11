using System;

namespace Menu
{
    class Program
    {
        static void Main(string[] args)
        {
            int op = -1;

            while (op != 0) {
                Console.Clear();
                Console.WriteLine( "======================================="
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
                               + "\n==== 1 - Cadastrar Cliente        ====="
                               + "\n=======================================");
                Console.WriteLine("Digite sua opção: ");
                op = Convert.ToInt16(Console.ReadLine());
                Console.Clear();

                    switch (op)
                    {
                    case 1:
                        Console.WriteLine("==== 1 - Cadastrar Cliente =====");

                        break;
                    case 2:
                        Console.WriteLine("==== 1 - Cadastrar Cliente =====");
                        break;
                    case 0:
                        Console.WriteLine("====       Saindo...       =====");
                        break;
                    default:
                        Console.WriteLine("Opção invalida");
                        break;
                    }
                Console.WriteLine(        "\n==== Pressione uma tecla  =====");
                Console.ReadKey();


            }
        }
    }
}
