using bootcamp.models;

namespace bootcamp.models{

    public sealed class Professor : Pessoa{

        public decimal  Salario { get; set; }

        public override void Apresentar()
        {
            Console.WriteLine($"me chamo {NomeCompleto}, sou um professor e ganho {Salario:C}");
        }
    }
}