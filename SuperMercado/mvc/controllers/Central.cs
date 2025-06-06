using static System.Console;
using cadastro;

namespace centralCadastro{
    public static class Central{

        public static void Print(){
            
            Write("\nPara cadastrar produto digite 1: ");
            Write("\nPara cadastrar cliente digite 2: ");

            char choose = Convert.ToChar(ReadLine());

            if(choose == '1'){
                Cadastrar.Produto();
            }
            else if(choose =='2'){
                Cadastrar.Cliente();
            }
            else{
                WriteLine("Opção inválida");
            }
        }
    }
}