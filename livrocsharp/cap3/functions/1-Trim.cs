using static System.Console;

namespace functrim{
    
    class TrimClass{
        static string nome = "      thalles        ";
        static string sobrenome = "     roberto    ";
        static string fullName = nome + sobrenome;
        static string fullName_trim = fullName.Trim();

        public TrimClass(string nome,string sobrenome){
            this.nome = nome = "     thalles    ";
        }
        static void fTrim(){
            WriteLine("\nTrim remove espaços antes e depois da string\n");
            WriteLine($"Nome original: {fullName}.");
            WriteLine($"Nome sem espaço: {fullName_trim}.");

        }
    }
    
}