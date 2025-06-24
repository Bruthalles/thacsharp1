using bootcamp.models;

namespace bootcamp.models{

    public class Aluno : Pessoa{

        public double Nota { get; set; }

        public override void Apresentar()
        {
            Console.WriteLine($"me chamo {NomeCompleto} e sou um aluno nota {Nota}");
        }
    }
}