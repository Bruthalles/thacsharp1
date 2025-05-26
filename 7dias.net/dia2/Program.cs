using pessoa;
using produto;
using static System.Console;

namespace dia2{
    class Program{
        static void Main(string[] args){
            Pessoa p = new Pessoa();
            Produto o = new Produto();
            p.Nome = "Thalles";
            p.Idade = 20;
            p.Apresentar(p);
            Write("\nDigite nome do produto: ");
            o.Nome = ReadLine();
            Write($"\nDigite valor do {o.Nome}: ");
            o.Preco = double.Parse(ReadLine());
            o.Estoque(o);

        }
    }
}