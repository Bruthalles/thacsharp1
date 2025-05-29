using static System.Console;
using System.IO;
using serializacao;
namespace dia5{
    class Dia5{
        static void Main(string[] args){

            //saindo de bin/Debug/net9.0/ para a raiz
            string caminhoProjeto = Directory.GetParent(Environment.CurrentDirectory)?.Parent?.Parent?.FullName;

            string nomeFile = "lista.txt";

            string caminhoArquivo = Path.Combine(caminhoProjeto,nomeFile);

            WriteLine($"Arquivo {nomeFile} criado em {caminhoArquivo}");

            List<string> tarefas = new List<string>();

            WriteLine("Digite tarefas. Digite 'fim' para encerrar:");
            string input;

            do{
                input = ReadLine();
                if(input != "fim"){
                    tarefas.Add(input);
                }
            }while( input != "fim");

            if(File.Exists(caminhoArquivo)){

                using (StreamWriter writer = new StreamWriter(caminhoArquivo,append:true)){
                    foreach(var task in tarefas){
                        writer.WriteLine($"- {task}");
                    }
                }
            }
            WriteLine("Lista de tarefas salva!");

            JSerial.PessoaSerial();
        }
    }
}