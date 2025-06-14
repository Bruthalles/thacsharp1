using static System.Console;
using static vars.Contents;
namespace functrim{
    
    public static class TrimClass{
        
        public static void fTrim(){
            WriteLine("\nTrim remove espaços antes e depois da string\n");
            WriteLine($"Nome original: {fullName}.");
            WriteLine($"Nome sem espaço: {fullName_trim}.");

        }
    }
    
}