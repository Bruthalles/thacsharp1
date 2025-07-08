namespace models.Negocios{
    public class Produto{
        private string _nome;
        private decimal _preco;
        private string _validadeString;
        private int _quantidade;

        public string Nome { 
            get=>_nome; 
            set {_nome = value;}
        }
        public decimal Preco{
            get => _preco;
            set{_preco = value;}
        }

        public string Validade{
            get => _validadeString;
            set{_validadeString = value;}
        }

        public int Quantidade{
            get => _quantidade;
            set{_quantidade = value;}
        }

        //metodos validados
        public bool DefinirNome(string nome){
            
            if(string.IsNullOrEmpty(nome)){
                Console.WriteLine("Nome nao pode ser nulo!");
                return false;
            }
            else{
                this.Nome = nome;
                return true;
            }
        }

        public bool DefinirPreco(decimal valor){
            
            if(!decimal.IsNegative(valor)){
                valor = Math.Round(valor,2);
                this.Preco = valor;
                return true;
            }
            else{
                Console.WriteLine("Valor inválido. Deve ser maior ou igual a 0");
                return false;
            }
        }

        public bool DefinirValidade(string validade){
            if(DateTime.TryParse(validade, out DateTime dataConvertida)){
               
                this.Validade = Convert.ToString(dataConvertida);
                return true;
            }
            else{
                Console.WriteLine("Nao foi possivel trabalhar com essa data");
                return false;

            }
        }
    
        public bool DefinirQuantidade(int quantidade){
            if(quantidade >= 0){
                this.Quantidade = quantidade;
                return true;
            }
            else {
                Console.WriteLine("Quantidade inválida!");
                return false;
            }
        }
    }
}