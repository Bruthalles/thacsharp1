using static System.Console;
using dia4;

namespace mainDia4{
        class Program{
            static void Main(string[] args){
            Caminhao caminhao= new Caminhao();
            Onibus bus = new Onibus();

            caminhao.Marca = "mercedez";
            caminhao.Modelo = " mark 1.5";
            caminhao.Ano = 2015;
            bus.Marca = "Volvo";
            bus.Modelo = "arkino 2000";
            bus.Ano = 2022;

            List<Veiculo> listaVeiculos = new List<Veiculo>{
                caminhao,
                bus
            };
            foreach(var veiculo in listaVeiculos){
                WriteLine($"Marca: {veiculo.Marca} | Modelo: {veiculo.Modelo} | Ano: {veiculo.Ano}" );
                veiculo.Mover();
                if(veiculo is ICombustivel movel){
                    movel.Abastecer();
                }
            }
        }
    }
}