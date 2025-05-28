using static System.Console;

namespace dia4{
    abstract class Veiculo {
        public virtual string? Marca {get ; set;}
        public virtual string? Modelo{get; set;}
        public virtual int Ano   {get; set;}

        public abstract void Mover();

       
    }
    interface ICombustivel{
        public void Abastecer();
    }
    class Carro : Veiculo, ICombustivel{
        public void Abastecer(){
            WriteLine("Abasteça com gasolina");
        }
        public override void Mover(){
            WriteLine("Carro se movendo com 4 rodas.");
        }
    }
    class Moto : Veiculo, ICombustivel{
        public void Abastecer(){
            WriteLine("Abasteça com etanois");
        }
        public override void Mover(){
            WriteLine("moto se movendo em uma roda nas ruas de SP.");
        }
    }

    class Caminhao : Veiculo, ICombustivel{

        public override string? Marca { get => base.Marca; set => base.Marca = value; }

        public override string? Modelo { get => base.Modelo; set => base.Modelo = value; }

        public override int Ano { get => base.Ano; set => base.Ano = value; }

        public void Abastecer(){
            Console.WriteLine("Diesel abastecido");
        }
        public override void Mover(){
            Console.WriteLine("Caminhao em movimento pesado");
        }
    }
    class Onibus : Veiculo, ICombustivel{

        public override string? Marca { get => base.Marca; set => base.Marca = value; }

        public override string? Modelo {get => base.Modelo; set => base.Modelo = value;}

        public override int Ano { get => base.Ano; set => base.Ano = value; }
        public void Abastecer(){
            Console.WriteLine("Etanol abastecido");
        }
        public override void Mover(){
            Console.WriteLine("Onibus levando passageiros");
        }
    }
}