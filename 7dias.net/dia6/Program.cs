using static System.Console;
using System.Diagnostics;
namespace dia6{

    class Program{
        static void validaIdade(int idade){
            if(idade < 18){
                throw new Exception("Idade inválida");
            }
        }
        static void Main(string[] args){

            try{
                WriteLine($"Digite sua idade:");
                int idade = int.Parse(ReadLine());
                validaIdade(idade);
                Debug.Assert(idade >= 18,"Idade deve ser maior ou igual a 18");
            }
            catch(FormatException){
                WriteLine("Digite apenas numeros");
            }
            catch(Exception e){
                WriteLine(e.Message);
            }
            finally{
                WriteLine("programa acabou");
            }
        }
    }
}