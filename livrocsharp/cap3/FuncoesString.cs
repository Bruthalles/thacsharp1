using System;
using System.Linq;
using static System.Console;

namespace cap3{
    class FuncoesString{
        static void Main(string[] args){

            string empresa = "Microsoft Corporation";

            string nome = "      thalles        ";
            string sobrenome = "     roberto    ";
            string fullName = nome + sobrenome;
            string fullName_trim = fullName.Trim();

            WriteLine("\n-----Funções de texto-----\n");
            WriteLine("Trim remove espaços antes e depois da string\n");
            WriteLine($"Nome original: {fullName}.");
            WriteLine($"Nome sem espaço: {fullName_trim}.");

            WriteLine("\nLength retorna a quantidade de caracteres\n");
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
                WriteLine("3 - nomes iguais");
            else
                WriteLine("3 - nomes diferentes");

            WriteLine("\nRemove - extrai x caracteres a partir da esquerda da string\n");
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
                                             
            WriteLine("\nSplit divide e extrai cada palavra em um array\n");
            string NivelLivro = "Exercicios acompanhados do livro C# para iniciantes";
            string[] blocos = NivelLivro.Split(' ');
            var contador =1;
            foreach(var exp in blocos){
                WriteLine($"texto {contador++}: {exp}");
            }
            WriteLine($"Quantidade de palavras: {blocos.Count()}");
            WriteLine($"Quantidade com length: {blocos.Length}");

            WriteLine("\nSubstring extrai parte da string\n");
            WriteLine(NivelLivro.Substring(1,14));
            
            int total = 0;
            string[] cesta = {"5 laranjas","10 goiabas vermelhas","5 pêssegos doces","10 bananas d'água"};
            foreach(var p in cesta){
                WriteLine($"{p.Substring(p.IndexOf(" ")+1)}");

                //pegando e somando as frutas
                total += int.Parse(p.Substring(0,p.IndexOf(" ")));
                
            }
            WriteLine($"No total serão {total} frutas");
        }
    }    
}