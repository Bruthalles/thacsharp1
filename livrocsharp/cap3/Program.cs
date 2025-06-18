using System.Globalization;
using static System.Console;
using functrim;
using funclength;
using funcUpLow;
using funcRemove;
using funcReplace;
using funcSplit;
using funcSubstring;
using funcNullEmpty;
using funcDates;

namespace cap3{
    class Program{
        public static decimal money = 8234552M;
        static void Main(string[] args){

            CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("pt-BR");
            
            WriteLine("\n-----Funções de texto-----\n");

            TrimClass.fTrim();
            LengClass.fLength();
            UpLowClass.fUpLow();
            RemoveClass.fRemove();
            ReplaceClass.fReplace();
            SplitClass.fSplit();
            SubstringClass.fSubstring();
            NullEmptyClass.fNullEmpty();
            DatesClass.fDates();
            
            //C de currency
            WriteLine($"{money:C}");
            WriteLine(money.ToString("C",CultureInfo.CreateSpecificCulture("en-US")));
        }
    }    
}