using System;
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
    class FuncoesString{
        static void Main(string[] args){

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
            
        }
    }    
}