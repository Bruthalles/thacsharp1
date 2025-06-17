using models.pessoa;
using models.curso;

namespace program{
    class Program{
        public static void Main(string[] args){
            Pessoa p1 = new Pessoa(nome:"thalles",sobrenome:"Brumatti",idade:20);
            //p1.Apresentar();

            Pessoa p2 = new Pessoa(nome:"josé",sobrenome:"bezerra");

            Curso cursoDeIngles = new Curso();
            cursoDeIngles.Nome = "Curso de ingles";
            cursoDeIngles.AdicionarAlunos(p1);
            cursoDeIngles.AdicionarAlunos(p2);
            cursoDeIngles.ListarAlunos();
        }
    }
}