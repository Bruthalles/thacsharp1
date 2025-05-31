using  static Calculadora.Calc;

namespace dia7{
    class Program {
        static void Main(string[] args){
            double a = 3.14;
            double b = 5;
            double c = 0;
            double d = 010.100;

            Somar(a,b);
            Subtrair(d,a);
            Multiplicar(b,d);
            Dividir(a,c);
        }
    }
}