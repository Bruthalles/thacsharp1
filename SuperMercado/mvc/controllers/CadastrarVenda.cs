using static System.Console;
using models.Negocios;
using static ManipuladorArquivos.ManipuladorArquivos;
using System.Text.Json;

namespace Mercado.Controllers.Cadastros{

    public class CadastrarVenda{
        
        //Gerando a compra
        public static void Comprar(){

            try{
                using(StreamReader reader = new StreamReader(ObterCaminhoArquivoDoFilhoCompleto("mvc/models/data/","estoque.json"))){

                }
            }
            catch{}
        }
    }
}