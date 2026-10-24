using static System.Console;
using System.Collections;
using Newtonsoft.Json;
using models;

namespace functions{

    public class PraticJson{

        void JsonFuns(){
        //(int id, string nome) tupla1 = (1,"robson");
        //(int id, string nome) tupla2 = (2,"alessandra");


        List<Vendas> vendasTotais = new List<Vendas>();

        //Vendas v1 = new Vendas(1,"cadeira gamer",350.50M);
        //Vendas v2 = new Vendas(2,"Microondas",250.99M);
        //Vendas v3 = new Vendas(3,"PC GAymer",2789.98M);

        //vendasTotais.Add(v1);
        //vendasTotais.Add(v2);
        //vendasTotais.Add(v3);

        bool start = true;

        do{ 
            Write("nome da venda: ");
            string nome = ReadLine();

            string ended = "FIM";

            if(nome.ToUpper() == ended){
                start = false;
            }

            else{
                Write("ID do produto: ");
                int id = Convert.ToInt32(ReadLine());

                Write($"Preço do produto {nome}: ");
                decimal valor = Convert.ToDecimal(ReadLine());
                Vendas v0 = new Vendas(id,nome,valor);

                vendasTotais.Add(v0);
                start = true;
            }
            
        }while(start == true);

        string serializado = JsonConvert.SerializeObject(vendasTotais, Formatting.Indented);

        File.AppendAllText("vendas.json",serializado);

        WriteLine(serializado);

        }
    }

}