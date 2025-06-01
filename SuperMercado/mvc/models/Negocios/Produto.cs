namespace absProduto{
    class Produto{
        private string nome;
        private double preco;
        private string validade;
        private int quantidade;

        public string Nome{
            get{return Nome;}
            set{if(!string.IsNullOrEmpty(value)){
                    nome = value;
                }
                Console.WriteLine("Nome não pode ser nulo");
            }
        }
        public double Preco{
            get{return Math.Round(preco,2);}
            set{preco = value;}
        }
        public string Validade{
            get{return validade;}
            set{if(!string.IsNullOrWhiteSpace(value)){
                validade = value;
                }
                Console.WriteLine("Validade não pode ser nulo");
            }
        }
        public int Quantidade{get;set;}
    }
}