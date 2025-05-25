using System;
using System.Linq;
using static System.Console;

namespace cap3{
    class FuncoesString{
        static void Main(string[] args)
        {
            string empresa = "Microsoft Corporation";

            string nome = "      thalles        ";
            string sobrenome = "     roberto    ";
            string fullName = nome + sobrenome;
            string fullName_trim = fullName.Trim();

            WriteLine("-----Funções de texto-----\n");
            WriteLine("Trim remove espaços antes e depois da string\n");
            WriteLine($"Nome original: {fullName}.");
            WriteLine($"Nome sem espaço: {fullName_trim}.\n");

            WriteLine("Length retorna a quantidade de caracteres\n");
            WriteLine($"Tamanho original: {fullName.Length}");
            WriteLine($"Tamanho sem espaços: {fullName_trim.Length}\n");

            string nomeUpper = "AIRTON SENNA";
            string nomeLower = "airton senna";

            WriteLine($"Comparando strings: ({nomeUpper}) e ({nomeLower})");

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
                WriteLine("3 - nomes iguais\n");
            else
                WriteLine("3 - nomes diferentes\n");

            WriteLine("Remove - extrai x caracteres a partir da esquerda da string\n");
            WriteLine($"Texto esquerdo: {nome.Remove(9)}.");

            string[] nomes = { "Silvio Santos", "José Bezerra", "Getúlio Vargas" };

            WriteLine($"Capturando apenas o primeiro nome das pessoas:\n{nomes[0]}\n{nomes[1]}\n{nomes[2]}\n");

            WriteLine("Resultado:\n");
            foreach (var n in nomes)
            {
                WriteLine($"{n.Remove(n.IndexOf(" "))}");
            }

            WriteLine("\nReplace substitui conteúdos da string\n");

            WriteLine($"Texto atual: {empresa}");
            string novaEmpresa = empresa.Replace("Microsoft", "Google");
            WriteLine($"Depois do replace: {novaEmpresa}");
        }
    }    
}