using System;

class estoquemercado
{
    static string[] produtosEstoque = new string[10]
    public static void MenuEstoque()
    {
        int opcaoEstoque;

    Console.WriteLine("--- MENU ESTOQUE ---");
    Console.WriteLine("(1) Listar produtos");
      Console.WriteLine("(2) Adicionar produtos");
     Console.WriteLine("(3) Remover produtos");
        Console.WriteLine(" Opcao Escolhida: ");
        opcaoEstoque = int.Parse(Console.ReadLine());

        if(opcaoEstoque == 1)
        {
            listarProdutos();
        }
        else if(opcaoEstoque == 2)
        {
            adicionarProdutos();
        }
          else if(opcaoEstoque == 3)
        {
            removerProdutos();
        }
        else
        {
            Console.WriteLine("Opcao invalida!")
        }

    }

     public static string adicionarProdutos()
    {
        string novoProduto;
        string[] produtoEstoque - new string[10];

    Console.WriteLine("--- ADICIONAR PRODUTOS ---");
    Console.WriteLine("Digite um produto para adicionar ao estoque");
        novoProduto = (Console.ReadLine());

        for(int 1 = 0; i < produtosEstoque.Length; i++)
        {
            produtosEstoque[i] - novoProduto
        }

        return produtosEstoque;
    }

    public static string[] removerProdutos(string[] produtosEstoque)
    {
        return"";
    }
}