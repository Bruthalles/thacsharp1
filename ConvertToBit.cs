using System;
using System.Linq;

namespace Binario{
    public class ConvertToBit{

        //pede confirmação para reiniciar o programa
        public static int Loop(){
            Console.Write("Deseja converter novamente ? S/N: ");

            /*evita erro de exceção sem tratamento, ao colocar mais de um caractere. ou escolhendo a opção N, o programa continuava
            */
            char resposta = char.ToUpper(Console.ReadKey().KeyChar);

            if(resposta == 'S'){
                ConvertToBit.Run();
            }
            else if(resposta != 'S'){
                Console.WriteLine("\nObrigado pela experiência:)");   
            }
            return 0;
        }
        public static int Run(){
            //conversão de decimal para binario sem usar pilha nem ponteiros

            //definindo numero maximo de bits
            int limiteBit = 10;

            int[] restos = new int[limiteBit];

            //valor decimal maximo para calculo:
            int max = 1023;

            Console.Write("\nEscolha um numero de 1 à 1023 para converter em binário: ");
            int num = Convert.ToInt32(Console.ReadLine());

            if (num < 0 || num > max){
                Console.WriteLine("\nNÃO É POSSÍVEL CONVERTER ESSE NÚMERO!");
                ConvertToBit.Loop();
            }
            while(num > 0 ){
                for(int i = 0; i < limiteBit; i++){
                    restos[i] = num % 2;
                    num = num / 2;
                } 
            }
            if(num >0 || num <= max ){
                Console.Write("Seu número em binário é: ");

                //é matemáticamente necessário inverter após o processo de divisão 
                foreach(int n in restos.Reverse()){
                    Console.Write(n);
                }
            }
        Console.WriteLine("\n(((((((((((((((())))))))))))))))");
        ConvertToBit.Loop();
        return 0; 
        }
    }
}