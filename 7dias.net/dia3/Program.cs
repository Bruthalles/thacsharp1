using static System.Console;
using System.Collections.Generic;

namespace dia3{

    class Dia3{
        static void Main(string[] args){
            
            string titulo;
            double valor;
            var estoque = new Dictionary<string, double>();
            int[] numeros = new int[5];
            List<string> nomes = new List<string>();

            for(int i = 0; i < numeros.Length; i++){
                Write($"\nDigite {i+1}° valor: ");
                numeros[i] = int.Parse(ReadLine());
            }

            WriteLine($"\n{string.Join(", ",numeros)}");
            WriteLine($"\nDigite um nome ou sair para finalizar: ");
            string input = ReadLine().ToLower();

            do {
                nomes.Add(input);
                WriteLine($"\nDigite um nome ou sair para finalizar: ");
                input = ReadLine();

                if(input == "sair")break;
            }while(true);

            WriteLine(string.Join(", ",nomes));
            WriteLine($"Removendo nomes que começam com A");

            //remove todos que começa com A
            nomes.RemoveAll(input => input.StartsWith("A",StringComparison.OrdinalIgnoreCase));

            WriteLine(string.Join(", ",nomes));

            do{
                Write("\nAdicione um produto ou digite 'fim' para sair: ");
                titulo = ReadLine();

                if(titulo == "fim") break;

                Write($"\nDigite o valor de '{titulo}: ");
                valor = double.Parse(ReadLine());
                estoque[titulo] = valor;
                
            }while(true);

            WriteLine($"\nTotal de produtos cadastrados: {estoque.Count}");
            
            foreach(var produto in estoque){
                WriteLine($"\n{produto.Key} : R${produto.Value:F2}");
            }
        }
    }
}