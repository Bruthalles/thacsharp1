namespace pessoa{
    class Pessoa {
        private string? nome;
        private int idade;

        // atribuição automática
        public int Idade{ get ; set ; }

        //usando lógica
        public string Nome {
            get { return nome; }
            set {
                if (!string.IsNullOrWhiteSpace(value)) {
                    nome = value;
                }
            }
        } 
        public void Apresentar(Pessoa pessoa){
            Console.WriteLine($"{nome}, {idade} anos");
        }
    }
}