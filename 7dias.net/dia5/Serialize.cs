using static System.Console;
using System.IO;
using System.Text.Json;
using pessoa;

namespace serializacao{
    class JSerial{
        public static void PessoaSerial(){
            string caminhoProjeto = Directory.GetParent(Environment.CurrentDirectory)?.Parent?.Parent?.FullName;
            
            string nomeFile = "pessoas.json";

            string caminhoArquivo = Path.Combine(caminhoProjeto,nomeFile);

            WriteLine($"Arquivo {nomeFile} criado em {caminhoArquivo}");

            Pessoa p = new Pessoa{Nome = "joaco", idade = 23};

            string json = JsonSerializer.Serialize(p);

            if(File.Exists(caminhoArquivo)){
                using (StreamWriter writer = new StreamWriter(caminhoArquivo,append:true)){
                    writer.WriteLine(json);
                }
            }
        }
    }
}