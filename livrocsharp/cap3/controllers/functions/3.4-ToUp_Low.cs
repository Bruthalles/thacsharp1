using static System.Console;
using static vars.Contents;

namespace funcUpLow{
    public static class UpLowClass{
        public static void fUpLow(){
             WriteLine($"Comparando strings: ({nomeUpper}) e ({nomeLower})");

            //comparação 1
            if (nomeUpper == nomeLower)
                WriteLine("1 - nomes iguais");
            else
                WriteLine("1 - nomes diferentes");

            //comparação 2
            if (nomeUpper.ToLower() == nomeLower)
                WriteLine("2 - nomes iguais");
            else
                WriteLine("2 - nomes diferentes");

            //comparação 3
            if (nomeUpper.Equals(nomeLower, StringComparison.OrdinalIgnoreCase))
                WriteLine("3 - nomes iguais");
            else
                WriteLine("3 - nomes diferentes");
        }

        
    }
}
