// 🗓 Plano de 7 Dias de Estudo .NET (Base Forte)
// ✅ Dia 1 – Fundamentos da Linguagem
// ✔️ Sintaxe básica (tipos, variáveis, operadores)

// ✔️ Métodos e funções

// ✔️ Debug com VS Code

// ✔️ Entrada/saída de dados

// Exercícios: mini programas com entrada do usuário e tratamento de strings.

using System.ComponentModel.DataAnnotations;
using static System.Console;

namespace dia1{
    class Dia1{

            static string LimpaEspacos(string nome){
                string limpo = nome.Trim();
                WriteLine($"Nome sem espaços: {limpo}.");
                return limpo;
            }
            static void SetMaiusculo(string nome){
                WriteLine($"Em maiúsculo: {nome.ToUpper()}");
            }
            static void Estatisticas(string nome){
                WriteLine($"Quantidade original: {nome.Length} caracteres");
                WriteLine($"Quantidade depois do Trim: {nome.Trim().Length}");
                if(nome.Length > 0){
                WriteLine($"Primeira letra é:'{nome[0]}'");
                WriteLine($"Ultima letra é: '{nome[nome.Length-1]}'");
                }
            }
            static bool CcontemLetraA(string nome){
                if(nome.ToLower().Contains('a')){
                    WriteLine("Este nome contem letra a");
                    return true;
                }
                else{
                    WriteLine("nao contem letra a");
                    return false;
                }
            }
            static void Main(string[] args){
            
            WriteLine("Digite seu nome completo com espaços no começo e no fim: ");

            string nome = ReadLine();
            
            WriteLine($"A entrada foi: {nome}.");
            LimpaEspacos(nome);
            SetMaiusculo(nome);
            Estatisticas(nome);
            CcontemLetraA(nome);
            Write("Digite um indice em inteiro para saber a posicão de uma letra: ");
            int posicao = int.Parse(ReadLine());

            if ( posicao >= 0 && posicao <= nome.Length)
                WriteLine($"A letra na posição {posicao} é: {nome[posicao]}");
            else
                WriteLine("Indice fora do alcance");
            
            WriteLine("Obrigado por esse programa");
            

        }
    }
}