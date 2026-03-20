using static System.Console;
using models.Negocios;
using static ManipuladorArquivos.ManipuladorArquivos;
using System.Text.Json;

namespace Mercado.Controllers.Cadastros{
    public class CadastrarGerente{
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
    }
}
