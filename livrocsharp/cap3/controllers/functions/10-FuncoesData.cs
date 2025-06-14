using static System.Console;
using static vars.Contents;
using System;
using System.Linq;
using System.Net.Mail;
using System.Globalization;

namespace funcDates{
    public static class DatesClass{
        public static DateTime dtFesta = new DateTime(2021,12,3);

        public static DateTime dtAniversario = new DateTime(ano,mes,dia);

        public static DateTime hoje ;

        public static DateTime dataHora;

        public static void fDates(){
            WriteLine("-----funções de datas-----");
            WriteLine($"Aniversario: {dtAniversario}");
            WriteLine($"Aniversario: {dtAniversario:dd/MM/yyyy}");
            WriteLine($"Aniversario: {dtAniversario:ddd/MMM/yyyy}");
            WriteLine($"Aniversario: {dtAniversario:dddd dd/MMMM/yyyy}");

            hoje = DateTime.Today;
            WriteLine("\nTODAY - retorna a data atual");
            WriteLine($"TODAY: {hoje:dd/MM/yy}");

            dataHora = DateTime.Now;
            WriteLine("\nNOW - retorna data e hora atual");
            WriteLine($"Data e hora: {dataHora:dddd dd/MM/yyyy hh:mm:ss}");

            WriteLine("DAY / MONTH / YEAR - captura dia mes e ano separadamente");

            WriteLine($"Dia: {dataHora.Day}");
            WriteLine($"Mês: {dataHora.Month}");
            WriteLine($"Ano: {dataHora.Year}");
        }
    }
}
