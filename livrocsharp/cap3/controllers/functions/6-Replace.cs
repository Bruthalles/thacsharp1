using static System.Console;
using static vars.Contents;

namespace funcReplace{
    public static class ReplaceClass{
        public static void fReplace(){
            WriteLine("\nReplace substitui conteúdos da string\n");

            WriteLine($"Texto atual: {empresa}");
            string novaEmpresa = empresa.Replace("Microsoft", "Google");
            WriteLine($"Depois do replace: {novaEmpresa}");
        }
    }
}