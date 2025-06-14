using static System.Console;
using static vars.Contents;
namespace funclength{
    class LengClass{
        public static void fLength(){
            WriteLine("\nLength retorna a quantidade de caracteres\n");
            WriteLine($"Tamanho original: {fullName.Length}");
            WriteLine($"Tamanho sem espaços: {fullName_trim.Length}\n");
        }
    }
}