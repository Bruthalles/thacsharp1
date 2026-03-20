using static System.Console;
using models.Negocios;
using static  ManipuladorArquivos.ManipuladorArquivos;
using System.Text.Json;
using System.Runtime.CompilerServices;

namespace models.Negocios{
    public static class DataBase{
        private static string arquivo_dados = ObterCaminhoArquivoDoFilhoCompleto("/models/data/","data.json");
        
        public static List<Produto> Produtos {get;private set;} = new ();
        public static List<Cliente> Clientes {get;private set;} = new ();
        public static List<Gerente> Gerentes {get;private set;} = new ();

        public static void AdicionarProduto(Produto p){
            Produtos.Add(p);
        }
        public static void AdicionarCliente(Cliente c){
            Clientes.Add(c);
        }
        public static void AdicionarGerente(Gerente g){
            Gerentes.Add(g);
        }

        public static void SalvarDados(){
            var dados = new {
                produtos = Produtos,
                clientes = Clientes,
                gerentes = Gerentes
            };

            string json = JsonSerializer.Serialize(dados,new JsonSerializerOptions{WriteIndented=true});



            if( File.Exists(arquivo_dados)){
                File.WriteAllText(arquivo_dados,json);
            }
            else{
                CriarArquivo(arquivo_dados,json);
            }
        }

        public static void CarregarDados(){
            if(!File.Exists(arquivo_dados)) return;

            string json = File.ReadAllText(arquivo_dados);

            var dados = JsonSerializer.Deserialize<Dictionary<string,JsonElement>>(json);

            if(dados != null){
                if (dados.ContainsKey("produtos"))
                    Produtos = JsonSerializer.Deserialize<List<Produto>>(dados["produtos"].GetRawText())!;
                if (dados.ContainsKey("clientes"))
                    Clientes = JsonSerializer.Deserialize<List<Cliente>>(dados["clientes"].GetRawText())!;
                if (dados.ContainsKey("gerentes"))
                    Gerentes = JsonSerializer.Deserialize<List<Gerente>>(dados["gerentes"].GetRawText())!;
                   
            }
        }
    }
}