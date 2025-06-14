namespace absProduto{
    public class Produto{
        private string nome;
        private decimal preco;
        private DateTime validade;
        private string validadeString;
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
        public string getValidade(int ano,int mes , int dia){
            validade = new DateTime(ano,mes,dia);
            validadeString = Convert.ToString(validade);
            return validadeString;
        }
        public int Quantidade{get;set;}
    }
}