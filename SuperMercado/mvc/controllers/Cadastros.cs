using static System.Console;
using absProduto;
using System.Text.Json;
using System.Collections.Generic;
using System.IO;

namespace cadastro{
    public class Cadastrar{
        public static void Produto(){
            
            Produto produto= new Produto();
            List<string> estoque = new List<string>();
            do{

            Write("\nDigite nome do novo produto ou 'fim' para sair do cadastro: ");
            string input = ReadLine();
            if(input == "fim")break;

            else{
            produto.Nome = input;

            Write($"\nDigite Preço de {produto.Nome}: ");
            produto.Preco = double.Parse(ReadLine());

            Write($"\nDigite validade de {produto.Nome}: ");
            produto.Validade = ReadLine();

            Write($"\nDigite Quantidade disponível para {produto.Nome}: ");
            produto.Quantidade = int.Parse(ReadLine());
            
            string json = JsonSerializer.Serialize(produto);
            estoque.Add(json);
            }

            }while(true);

            string? caminhoProjeto = Directory.GetParent(Environment.CurrentDirectory)?.Parent?.Parent?.FullName;
            
            
        }
    }
}