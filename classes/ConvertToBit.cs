using System;
using System.Linq;

namespace Binario{
    public class ConvertToBit{
        public static int Run(){
            //conversão de decimal para binario sem usar pilha nem ponteiros


            /*cada indice equivale a um bit do numero decimal.
            com 4 bits o maior numero possivel é 15
            */
            int[] restos = new int[4];

            //valor decimal maximo para calculo:
            int max = 15;

            Console.Write("escolha um numero de 1 à 15 para converter em binário: ");
            int num = Convert.ToInt32(Console.ReadLine());

            if (num < 0 || num > max){
                Console.WriteLine("não é possivel converter esse numero!");
            }

            while(num > 0 ){
                for(int i = 0; i < 4; i++){
                    restos[i] = num % 2;
                    num = num / 2;
                } 
            }
            Console.Write("Seu número em binário é: ");

            foreach(int i in restos.Reverse()){
                Console.Write(restos[i]);
            }
            
            return 0;
        }
    }
}