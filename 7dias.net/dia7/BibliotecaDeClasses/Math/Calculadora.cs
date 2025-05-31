using static System.Console;

namespace Calculadora{
    public class Calc{
        public static void Somar(double a, double b){
            double sum = a + b;
            WriteLine($"Resultado de {a} + {b} = {sum}");
        }
        public static void Subtrair(double a,double b){
            double sub = a - b;
            WriteLine($"Resultado de {a} - {b} = {sub}");
        }
        public static void Multiplicar(double a, double b){
            double mult = a * b;
            WriteLine($"Resultado de {a} x {b} = {mult}");
        }
        public static void Dividir(double a, double b ){
            if(!(a == 0 || b == 0)){
                double div = a / b;
                WriteLine($"Resultado de {a} % {b} = {div}");
            }
            WriteLine("Não é possível dividir por 0 !");
        }
    }
}