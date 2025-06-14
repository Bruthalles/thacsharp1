using static System.Console;
using static vars.Contents;

namespace funcSplit{
    public static class SplitClass{
        public static void fSplit(){
            WriteLine("\nSplit divide e extrai cada palavra em um array\n");
            
            string[] blocos = nivelLivro.Split(' ');
            var contador =1;
            foreach(var exp in blocos){
                WriteLine($"texto {contador++}: {exp}");
            }
            WriteLine($"Quantidade de palavras: {blocos.Count()}");
            WriteLine($"Quantidade com length: {blocos.Length}");
        }
    }
}