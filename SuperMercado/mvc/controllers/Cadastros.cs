using static System.Console;
using absProduto;
using cliente;
using static getpath.GetPath;
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
            CriarJson("estoque",estoque);

        }
        public static void Cliente(){

            Cliente cliente = new Cliente();
            List<string> lstCustomers = new List<string>();

            Write($"\nCadastrar nome do cliente: ");
            cliente.Nome = ReadLine();

            string jsonCliente = JsonSerializer.Serialize(cliente);
            lstCustomers.Add(jsonCliente);

            CriarJson("clientes",lstCustomers);
        }
    }
}