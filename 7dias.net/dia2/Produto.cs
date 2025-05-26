namespace produto{
    class Produto {
        //apropriação automática
        public double Preco { get; set; }
        public string? Nome {get;set;}

        public void Estoque(Produto produto){
            Console.WriteLine($"{Nome}, {Preco}");
        }
    }
}