using bootcamp.models;

namespace bootcamp.models{
    public class Curso{
        public string Nome { get; set; }
        public List<Pessoa> Alunos { get; set; } = new List<Pessoa>();

        public void AdicionarAlunos(Pessoa aluno){
            Alunos.Add(aluno);
        }
        public int ObterQuantidadeDeAlunosCadastrados(){
            int quantidade = Alunos.Count;
            return quantidade;
        }
        public bool RemoverAluno( Pessoa aluno){
            return Alunos.Remove(aluno);
        }
        public void ListarAlunos(){
            Console.WriteLine($"Alunos no {Nome}");
            foreach(Pessoa aluno in Alunos){
                Console.WriteLine(aluno.NomeCompleto);
            }
        }
    }
}