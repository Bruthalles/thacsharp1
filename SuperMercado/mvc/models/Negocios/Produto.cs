namespace absProduto{
    public class Produto{
        private string nome;
        private double preco;
        private string validade;
        private int quantidade;

        public string Nome{
            get{return Nome;}
            set{if(!string.IsNullOrEmpty(value)){
                    Nome = value;
                }
                Console.WriteLine("Nome não pode ser nulo");
            }
        }
        public double Preco{
            get{return Math.Round(Preco,2);}
            set{Preco = value;}
        }
        public string Validade{
            get{return Validade;}
            set{if(!string.IsNullOrWhiteSpace(value)){
                Validade = value;
                }
                Console.WriteLine("Validade não pode ser nulo");
            }
        }
        public int Quantidade{get;set;}
    }
}