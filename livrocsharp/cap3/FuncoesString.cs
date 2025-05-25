using System;
using System.Linq;
using static System.Console;

namespace cap3{
    class FuncoesString
    {
        static void Main(string[] args)
        {
            string nome = "      thalles        ";
            string sobrenome = "     roberto    ";
            string full_name = nome + sobrenome;
            string full_name_trim = full_name.Trim();

            WriteLine("-----Funções de texto-----");
            WriteLine("TRIM remove espaços antes e depois da string");
            WriteLine($"Nome original: {full_name}.");
            WriteLine($"Nome sem espaço: {full_name_trim}.");

            WriteLine("Length retorna a quantidade de caracteres");
            WriteLine($"Tamanho original: {full_name.Length}");
            WriteLine($"Tamanho sem espaços: {full_name_trim.Length}\n");

            string nomeUpper = "AIRTON SENNA";
            string nomeLower = "airton senna";

            //comparação 1
            if (nomeUpper == nomeLower)
                WriteLine("1 - nomes iguais");
            else
                WriteLine("1 - nomes diferentes");

            //comparação 2
            if (nomeUpper.ToLower() == nomeLower)
                WriteLine("2 - nomes iguais");
            else
                WriteLine("2 - nomes diferentes");

            //comparação 3
            if (nomeUpper.Equals(nomeLower, StringComparison.OrdinalIgnoreCase))
                WriteLine("3 - nomes iguais");
            else
                WriteLine("3 - nomes diferentes");

        }
    }    
    
}