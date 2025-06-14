using static System.Console;
using static vars.Contents;

namespace funcSubstring{
    public static class SubstringClass{
        public static void fSubstring(){
            WriteLine("\nSubstring extrai parte da string\n");
            WriteLine(nivelLivro.Substring(1,14));
            
            int total = 0;
            
            foreach(var p in cesta){
                WriteLine($"{p.Substring(p.IndexOf(" ")+1)}");

                //pegando e somando as frutas
                total += int.Parse(p.Substring(0,p.IndexOf(" ")));
            }
            WriteLine($"No total serão {total} frutas");
        }
    }
}