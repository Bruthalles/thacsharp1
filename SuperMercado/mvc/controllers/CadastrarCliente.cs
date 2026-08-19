using static System.Console;
using models.Negocios;
using static ManipuladorArquivos.ManipuladorArquivos;
using System.Text.Json;

namespace Mercado.Controllers.Cadastros{
    
    public class CadastrarCliente{
        //Cadastrando novo Cliente
        public static void newCliente(){


            Cliente cliente = new Cliente();
            Write($"\nCadastrar nome do cliente: ");
            cliente.Nome = ReadLine();

            List<string> lstCustomers = new List<string>();

            string jsonCliente = JsonSerializer.Serialize(cliente);

            lstCustomers.Add(jsonCliente);

            string arquivoClientes = ObterCaminhoArquivoDoFilhoCompleto("/mvc/models/data/","clientes.json");
            
            CriarArquivo(arquivoClientes,JsonSerializer.Serialize(lstCustomers));
        }
    }
}