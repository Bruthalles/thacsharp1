using static System.Console;
using models.Negocios;
using static ManipuladorArquivos.ManipuladorArquivos;
using System.Text.Json;

namespace Mercado.Controllers.Cadastros{
    public class CadastrarProduto{

        //Cadastrando Produto
        public static void newProduto(){
            
            Produto produto; 
            List<string> estoque = new List<string>();
            do{

            Write("\nDigite nome do novo produto ou 'fim' para sair do cadastro: ");
            string input = ReadLine();
            if(input == "fim")break;
            
            else{
                produto = new Produto();

                if(!produto.DefinirNome(input)) continue;

                Write($"\nDigite Preço de {produto.Nome}: ");

                if(!produto.DefinirPreco(Convert.ToDecimal(ReadLine()))) continue;
                
                Write($"\nDigite validade de {produto.Nome} AAAA/MM/DD: ");

                if(!produto.DefinirValidade(ReadLine())) continue;

                Write($"\nDigite Quantidade disponível para {produto.Nome}: ");
                
                if(!produto.DefinirQuantidade(int.Parse(ReadLine()))) continue;
                
                string json = JsonSerializer.Serialize(produto);
                estoque.Add(json);
                }

            }while(true);
            string arquivoProdutos = ObterCaminhoArquivoDoFilhoCompleto("/mvc/models/data/","estoque.json");
            CriarArquivo(arquivoProdutos,estoque);

        }
    }
}