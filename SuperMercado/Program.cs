using System.ComponentModel.DataAnnotations.Schema;
using centralCadastro;
using models.Negocios;
namespace Mercado{
    class PRogram{
        static void Main(string[] args){
            Central.Print();
            DataBase.CarregarDados();
        }
    }
}