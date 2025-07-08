using static System.Console;
using Mercado.Controllers.Cadastros;

namespace centralCadastro{
    public static class Central{

        public static void Print(){
            
            Write("\nDigite 1 para entrar como Gerente: ");
            Write("\nDigite 2 para entrar como Cliente: ");

            char choose = Convert.ToChar(ReadLine());

            switch(choose){
                case '1': 
                    Cadastrar.newGerente();
                    Cadastrar.newProduto();
                    break;
                case '2':
                    Cadastrar.newCliente();
                    break;
                default:
                    WriteLine("Opção inválida");
                    break;
            }
        }
    }
}