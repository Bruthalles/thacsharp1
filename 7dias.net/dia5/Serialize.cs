using static System.Console;
using System.IO;
using System.Text.Json;
using pessoa;
using System.Linq.Expressions;

namespace serializacao{
    class JSerial{
        public static void PessoaSerial(){
            string caminhoProjeto = Directory.GetParent(Environment.CurrentDirectory)?.Parent?.Parent?.FullName;

            string nomeFile = "pessoas.json";

            string caminhoArquivo = Path.Combine(caminhoProjeto,nomeFile);

            Pessoa p = new Pessoa{Nome = "joaco", idade = 23};

            string json = JsonSerializer.Serialize(p);

            if(File.Exists(caminhoArquivo) == false){
                WriteLine($"Criando arquivo {nomeFile}");

                //using abre o arquivo e fecha ao terminar o código dentro do bloco
                using (StreamWriter writer = new StreamWriter(caminhoArquivo)){
                    //cria o arquivo se não existir, e depois escreve
                    writer.WriteLine("");
                }
                WriteLine($"Arquivo {nomeFile} criado em {caminhoArquivo}");
            }

            try{
                File.Exists(caminhoArquivo);
                
                //append adiciona inves de sobrescrever
                using (StreamWriter writer = new StreamWriter(caminhoArquivo,append:true)){
                    writer.WriteLine(json);
                }
                WriteLine($"Objeto Pessoa salva como json em {nomeFile}");
            }
            
            catch (FileNotFoundException fne){
                WriteLine("Erro, arquivo nao criado: ");
                WriteLine(fne.Message);
                WriteLine(fne.Data);
                WriteLine(fne.FileName);
                WriteLine(fne.Source);
            }
        }
    }
}