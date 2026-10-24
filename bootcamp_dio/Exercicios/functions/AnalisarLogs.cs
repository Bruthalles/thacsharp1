using static System.Console;
using System.Linq;
using System.IO;

namespace functions{
    
    public static class Functions{

        public static void AnalisarLogs(){
            WriteLine("Pronto para receber os Logs...");
            
            bool index = true; 
            List<string> logs = new List<string>();

            do{
                WriteLine("Adicionar Log, ou digite FIM. ");
                string iLog = ReadLine();

                string stop = "FIM";

                if(iLog.ToUpper() != stop){
                    logs.Add(iLog);
                    WriteLine("Log adicionado...");
                }
                else if(iLog.ToUpper() == stop)
                    index = false;
                
            }while(index);

            string[] partes = [];
            
            string file = "logs.txt";


            for( int i = 0; i < logs.Count(); i++){

                File.AppendAllText(file, logs[i]);
                partes = logs[i].Split("|");

                WriteLine($"Nivel: {partes[i]} \nMensagem: {partes[i+1]}");
/* 

INFO|Usuario admin realizou login
ERROR|Falha ao conectar com banco de dados
WARNING|Espaco em disco abaixo de 20%
INFO|Usuario thalles realizou login
ERROR|Falha ao conectar com banco de dados
INFO|Usuario maria realizou logout

*/
            }


            //string[] messages = ["ERROR","WARNING","INFO"];
            //for (int i = 0; i < messages.Count(); i++){

            //    if (logs.Contains(messages[i])){
                    
                    
            //    }
                
            //}


            //for(int i = 0; i < logs.Count(); i++){
            //    WriteLine(logs[i]);
            //}


        }    
    }
}
