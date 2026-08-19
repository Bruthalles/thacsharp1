using static System.Console;

namespace Calculadora {
    
    public static class Calculadora{

// quantidades variadas para calculos:
//         int Somar(params int[] numeros)
// {
//     int soma = 0;
//     foreach (int n in numeros)
//         soma += n;
//     return soma;
// }

// Console.WriteLine(Somar(1, 2, 3, 4, 5)); // saída: 15

        //modulando tarefa de obter dois valores
        public static string[] OperacaoDoisValores() {
            Write("Digite 2 numeros separados por virgula: ");
            string[] valores = ReadLine().Split(",");
            if (valores.Length != 2 ) {
                WriteLine($"A Quantidade de {valores.Length} valores é inválida");
            }
            return valores;
        }
        public static void Somar() {
          
            string[] valores = OperacaoDoisValores();
            int a,b;
            a = Convert.ToInt32(valores[0]);
            b = Convert.ToInt32(valores[1]);
            WriteLine($"{a} + {b} = {a + b}");
        }
        public static void Subtrair() {

            string[] valores = OperacaoDoisValores();
            int a = Convert.ToInt32(valores[0]);
            int b = Convert.ToInt32(valores[1]);
            WriteLine($"{a} - {b} = {a - b}");
            
        }
        public static void Multiplicar() {

            string[] valores = OperacaoDoisValores();
            int a = Convert.ToInt32(valores[0]);
            int b = Convert.ToInt32(valores[1]);
            WriteLine($"{a} x {b} = {a * b}");
        }
        public static void Dividir() {

            string[] valores = OperacaoDoisValores();
            int a = Convert.ToInt32(valores[0]);
            int b = Convert.ToInt32(valores[1]);
            WriteLine($"{a} / {b} = {a / b}");
        }

        public static void Seno() {

            Write("Digite um angulo para seno: ");
            double angulo = Convert.ToDouble(ReadLine());
            double radiano = angulo * Math.PI / 180.0;
            WriteLine($"O seno de {angulo} é: {Convert.ToString(Math.Sin(radiano))}"); 
        }

        public static void Coseno() {

            Write("Digite um angulo para cosseno: ");
            double angulo = Convert.ToDouble(ReadLine());
            double radiano = angulo * Math.PI / 180.0;
            WriteLine($"O coseno de {angulo} é: {Convert.ToString(Math.Cos(radiano))}");
        }

        public static void Tangente() {

            Write("Digite um angulo para seno: ");
            double angulo = Convert.ToDouble(ReadLine());
            double radiano = angulo * Math.PI / 180.0;
            WriteLine($"A tangente de {angulo} é: {Convert.ToString(Math.Tan(radiano))}");
        }

        public static void Tabuada() {
            Write("Digite um numero para a tabuada: ");
            int n = int.Parse(ReadLine());
            WriteLine(n);

            for ( int i = 0; i <= 10; i++) {
                WriteLine($"{n} x {i}: {n*i}");
            }
        }

        public static void Raiz() {

            Write("Digite um numero para a raiz: ");
            double n = Convert.ToDouble(ReadLine());
            WriteLine($"Raiz quadrada de {n}: {Math.Sqrt(n)}");
        }

        public static void Modulo() {

            Write("Digite um numero para o módulo: ");
            int n = Convert.ToInt32(ReadLine());
            WriteLine($"Módulo de {n}: {Math.Abs(n)}");
        }
    }
}