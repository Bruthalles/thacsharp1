using static System.Console;
using static vars.Contents;

namespace funcRemove{
    public static class RemoveClass{
        public static void fRemove(){
             WriteLine("\nRemove - extrai x caracteres a partir da esquerda da string\n");
            WriteLine($"Texto esquerdo: {nome.Remove(9)}.");

            WriteLine($"Capturando apenas o primeiro nome das pessoas:\n{list_nomes[0]}\n{list_nomes[1]}\n{list_nomes[2]}\n");

            WriteLine("Resultado:\n");
            foreach (var n in list_nomes)
            {
                WriteLine($"{n.Remove(n.IndexOf(" "))}");
            }
        }
    }
}