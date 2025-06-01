namespace cliente{
    class Cliete{
        private string nome;
        public string Nome{
            get{return nome;}
            set{if(!string.IsNullOrWhiteSpace(value)){
                nome = value;
                }
                Console.WriteLine("Nome não pode ser nulo");
            }
        }
    }
}