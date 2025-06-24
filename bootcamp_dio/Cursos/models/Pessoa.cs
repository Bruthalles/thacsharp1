using static System.Console;

namespace bootcamp.models{
    public class Pessoa{

        public Pessoa(){}
        public Pessoa(string nome , string sobrenome){
            Nome = nome;
            Sobrenome = sobrenome;
        }
        public Pessoa(string nome , string sobrenome,int idade){
            Nome = nome;
            Sobrenome = sobrenome;
            Idade = idade;
        }
        private string _nome;
        private string _sobrenome;
        private int _idade;

        public string Nome { 
            get => _nome;
            set{
                if(value == " "){
                    throw new ArgumentException("nome nao pode ser nulo");
                }
                _nome = value;
            } 
        }
        public string  Sobrenome { 
            get =>_sobrenome; 
            set{if(value == " "){
                throw new ArgumentException("sobrenome nao pode ser nulo");
                }
                _sobrenome = value;
            } 
        }
        public string NomeCompleto { get => $"{Nome} {Sobrenome}".ToUpperInvariant(); }
        public int Idade { 
            get => _idade;
            set{if(value < 1){
                throw new ArgumentException("idade nao pode ser menor que 1");
                }
                _idade = value;
            } 
        }
        public virtual void Apresentar(){
            WriteLine($"Nome: {NomeCompleto}, Idade: {Idade}");
        }
    }
}