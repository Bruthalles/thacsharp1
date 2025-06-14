using static System.Console;
using static vars.Contents;

namespace funcNullEmpty{
    public static class NullEmptyClass{
        public static void fNullEmpty(){
            WriteLine("\nIsNullOrEmpty verifica se a string é nula ou vazia.\n");

            nome = "rex";
            sobrenome = null;
            
            if (!String. IsNullOrEmpty(nome) && !String.
IsNullOrEmpty(sobrenome)){
                WriteLine($"Nome completo: {nome} {sobrenome}");
            }
            else{
                WriteLine($"{nome} não tem sobrenome.");
            }
        }
    }
}