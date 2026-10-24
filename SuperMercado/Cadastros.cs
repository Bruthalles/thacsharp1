using static System.Console;
using Newtonsoft.Json;

namespace SuperMercado{
    public static class Cadastro{
        public static void CadastrarUsuarios(){    
            WriteLine("Digite 1 para cadastrar Gerente.");
            WriteLine("Digite 2 para cadastrar Cliente.");

            int value = Convert.ToInt32(ReadLine());

            if(value == 1){
                
                Gerente managr = new Gerente();
                Write("Cadastre nome do Gerente: ");
                managr.Nome = ReadLine();

                bool index;
                do {
                    Write("Cadastre o ID: ");
                    string inputId = ReadLine();
                
                    bool success = int.TryParse(inputId, out int newId);
                
                    if(success){
                        managr.Id = newId;
                    }
                    else {
                        WriteLine("Valor não é válido como inteiro");
                    }
                    index = success;
                    
                } while(!index);

                string jsonManager = JsonConvert.SerializeObject(managr);
                File.AppendAllText()

                WriteLine(jsonManager);
            }
        }
    }
}
