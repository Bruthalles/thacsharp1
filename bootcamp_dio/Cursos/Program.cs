using models.pessoa;
using models.curso;
using static getpath.GetPath;
using static System.Console;
using System;
using System.Linq;
using System.IO;

namespace program{
    public class Program{

        public static string[] linhas = File.ReadAllLines(ObterCaminhoArquivo("textoleitura.txt"));
        public static void Main(string[] args){

            foreach(string linha in linhas){
                WriteLine(linha);
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