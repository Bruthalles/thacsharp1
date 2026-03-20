using static System.Console;
using models.Negocios;
using static ManipuladorArquivos.ManipuladorArquivos;
using System.Text.Json;

namespace Mercado.Controllers.Cadastros{
    
    public class CadastrarCliente{
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
    }
}