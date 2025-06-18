using models.pessoa;
using models.curso;
using static getpath.GetPath;
using static System.Console;
using System;
using System.Linq;
using System.IO;

namespace program{
    public class Program{

        private static string caminhoFinal; 
        public static string[] linhas;
        public static void Main(string[] args){
            try{
                caminhoFinal = ObterCaminhoArquivoDoFilhoCompleto(nomePai:"/files/",nomeArquivo:"textoleitura.txt");
                linhas = File.ReadAllLines(caminhoFinal);

                foreach(string linha in linhas){
                    WriteLine(linha);
                }
            }
            catch(FileNotFoundException ex){
                WriteLine($"Ocorreu um erro. Arquivo nao encontrado {ex.Message}");
                WriteLine("Verifique o nome do arquivo.");
            }
            catch(DirectoryNotFoundException ex){
                WriteLine($"Ocorreu um erro: Diretorio nao encontrado {ex.Message}");
                WriteLine("Verifique o nome da pasta pai.");
            }
            catch(Exception ex){
                WriteLine($"Ocorreu uma excessão inesperada {ex.Message}");
            }
            WriteLine("Não foi possivel ler o arquivo, e o programa terminou.");
        }
    }
}



            // Pessoa p1 = new Pessoa(nome:"thalles",sobrenome:"Brumatti",idade:20);
            // //p1.Apresentar();

            // Pessoa p2 = new Pessoa(nome:"josé",sobrenome:"bezerra");

            // Curso cursoDeIngles = new Curso();
            // cursoDeIngles.Nome = "Curso de ingles";
            // cursoDeIngles.AdicionarAlunos(p1);
            // cursoDeIngles.AdicionarAlunos(p2);
            // cursoDeIngles.ListarAlunos();