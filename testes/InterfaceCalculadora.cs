using static System.Console;
using  static Calculadora.Calculadora;

namespace InterfaceCalculadora {
    
    public static class InterfaceCalculadora {
        
        public static void Menu() {
            string menu = "Digite:\n1  para somar\n2  para subtrair\n3  para multiplicar\n4  para dividir\n5  para seno\n6  para cosseno\n7  para tangente\n8  para tabuada\n9  para raiz\n10 para módulo: ";

            Write(menu);
            int choose = Convert.ToInt32(ReadLine());

            switch (choose) {
                case 0:
                    WriteLine("Numero invalido");
                    Menu();
                    break;
                case 1:
                    Somar();
                    Menu();
                    break;
                case 2:
                    Subtrair();
                    Menu();
                    break;
                case 3:
                    Multiplicar();
                    Menu();
                    break;
                case 4:
                    Dividir();
                    Menu();
                    break;
                case 5:
                    Seno();
                    Menu();
                    break;
                case 6:
                    Coseno();
                    Menu();
                    break;
                case 7:
                    Tangente();
                    Menu();
                    break;
                case 8:
                    Tabuada();
                    Menu();
                    break;
                case 9:
                    Raiz();
                    Menu();
                    break;
                case 10:
                    Modulo();
                    Menu();
                    break;
            }
            

            
        }
    }
}
