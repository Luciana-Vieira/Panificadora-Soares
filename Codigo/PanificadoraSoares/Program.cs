using System;

namespace CadastroProdutosPadaria
{
    class Produto
    {
        public int codigo;
        public string nome;
        public double preco;

        public Produto(int codigo, string nome, double preco)
        {
            this.codigo = codigo;
            this.nome = nome;
            this.preco = preco;
        }

        public override string ToString()
        {
            return "Código: " + codigo + ", Nome: " + nome + ", Preço: R$" + preco;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Produto[] produtos = new Produto[100];
            int contador = 0;

            while (true)
            {
                Console.WriteLine("=== Menu ===");
                Console.WriteLine("1 - Cadastrar produto");
                Console.WriteLine("2 - Listar produtos");
                Console.WriteLine("0 - Sair");

                int opcao = int.Parse(Console.ReadLine());

                if (opcao == 0)
                {
                    break;
                }
                else if (opcao == 1)
                {
                    Console.Write("Digite o código do produto: ");
                    int codigo = int.Parse(Console.ReadLine());

                    Console.Write("Digite o nome do produto: ");
                    string nome = Console.ReadLine();

                    Console.Write("Digite o preço do produto: R$");
                    double preco = double.Parse(Console.ReadLine());

                    produtos[contador] = new Produto(codigo, nome, preco);
                    contador++;

                    Console.WriteLine("Produto cadastrado com sucesso!");
                }
                else if (opcao == 2)
                {
                    Console.WriteLine("=== Lista de Produtos ===");

                    for (int i = 0; i < contador; i++)
                    {
                        Console.WriteLine(produtos[i]);
                    }
                }
                else
                {
                    Console.WriteLine("Opção inválida!");
                }

                Console.WriteLine();
            }
        }
    }
}
