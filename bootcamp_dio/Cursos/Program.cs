using bootcamp.models;
using static ManipuladorArquivos.ManipuladorArquivos;
using static System.Console;
using System;
using System.Linq;
using System.IO;

namespace program{
    public class Program{

        private static string caminhoFinal; 
        public static string[] linhas;
        public static void Main(string[] args){

            Queue<int> fila = new Queue<int>();
            Stack<int> pilha = new Stack<int>();

            fila.Enqueue(23);
            pilha.Push(10);
            fila.Dequeue();
            pilha.Pop();

            Dictionary<int,string> estados = new Dictionary<int, string>();
            estados.Add(21,"RJ");
            estados.Add(11,"SP");
            estados.Add(38,"BA");
            estados.Add(55,"BR");
            estados[38] = "MG";
            estados.Remove(55);
            estados.ContainsKey(22);
            estados.ContainsValue("RJ");

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
                WriteLine($"Ocorreu uma exceção inesperada {ex.Message}");
            }
            finally{
                WriteLine("fim do programa.");
            }
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