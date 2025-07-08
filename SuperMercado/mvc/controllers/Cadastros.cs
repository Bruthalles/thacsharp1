using static System.Console;
using models.Negocios;
using static ManipuladorArquivos.ManipuladorArquivos;
using System.Text.Json;
using System.Collections.Generic;
using System.IO;

namespace Mercado.Controllers.Cadastros{
    public class Cadastrar{

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
        //Cadastrando novo Cliente
        public static void newCliente(){

            Cliente cliente = new Cliente();
            List<string> lstCustomers = new List<string>();

            Write($"\nCadastrar nome do cliente: ");
            cliente.Nome = ReadLine();

            string jsonCliente = JsonSerializer.Serialize(cliente);
            lstCustomers.Add(jsonCliente);

            string arquivoClientes = ObterCaminhoArquivoDoFilhoCompleto("/mvc/models/data/","clientes.json");
            CriarArquivo(arquivoClientes,lstCustomers);
        }
        //Cadastrando novo Gerente
        public static void newGerente(){
            Gerente admin = new Gerente();
            List<string> lstAdmin = new List<string>();

            Write($"\nCadastre nome do gerente: ");
            admin.Nome = ReadLine();

            Write($"\nCadastre o ID do gerente {admin.Nome}: ");
            admin.Id = ReadLine();

            Write($"\nCadastre uma senha para o gerente {admin.Nome}: ");
            admin.Senha = ReadLine();

            string jsonGerente = JsonSerializer.Serialize(admin);
            lstAdmin.Add(jsonGerente);

            string arquivoGerentes = ObterCaminhoArquivoDoFilhoCompleto("/mvc/models/data/","gerentes.json");
            CriarArquivo(arquivoGerentes,lstAdmin);
        }

        //Gerando a compra
        public void Comprar(){

            try{
                using(StreamReader reader = new StreamReader(ObterCaminhoArquivoDoFilhoCompleto("mvc/models/data/","estoque.json"))){

                }
            }
            catch{}
        }
    }
}