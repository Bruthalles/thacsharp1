using System;
using System.Linq;
using static System.Console;

namespace FuncoesString{
    class EspacoTrim{

        static void Main(string[] args){

            int cpf = 123456789;
            string nome = "         thalles      ";
            string sobrenome = "     roberto        ";
            string full_name = nome + sobrenome;

            WriteLine("------Funções de Textos------");
            WriteLine("TRIM - retira os espaços vazios antes e depois da string");
            WriteLine($"Nome original: ({full_name})");
            WriteLine($"Nome sem espaço: {full_name.Trim()}.");
        }
    }
}