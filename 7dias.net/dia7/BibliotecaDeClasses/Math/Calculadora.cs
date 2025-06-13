using static System.Console;

namespace Calculadora{
    public static class Calc{
        public static void Somar(double a, double b){
            double sum = a + b;
            WriteLine($"Resultado de {a} + {b} = {sum}");
        }
        public static void Subtrair(double a,double b){
            double sub = a - b;
            WriteLine($"Resultado de {a} - {b} = {Math.Round(sub,2)}");
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
        public static void Potencia(double a,double b){
            double pot = Math.Pow(a,b);
            WriteLine($"Potencia de {a}^{b} = {pot}");
        }
        public static void Seno(double angulo){
            double radiano = angulo * Math.PI / 180;
            double seno = Math.Sin(radiano);
            WriteLine($"Seno de {angulo} = {Math.Round(seno,4)}");
        }
        public static void Coseno(double angulo){
            double radiano = angulo * Math.PI / 180;
            double coseno = Math.Cos(radiano);
            WriteLine($"Coseno de {angulo} = {Math.Round(coseno,4)}");
        }
        public static void Tangente(double angulo){
            double radiano = angulo * Math.PI / 180;
            double tangente = Math.Tan(radiano);
            WriteLine($"Tangente de {angulo} = {Math.Round(tangente,4)}");
        }
        public static void RaizQuadrada(double x){
            double raiz = Math.Sqrt(x);
            WriteLine($"Raiz Quadrada de {x} = {raiz}");
        }
    
    
    
    }
}