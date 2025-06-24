using bootcamp.models;

namespace bootcamp.models{
    public class ContaCorrente : Conta{

        public ContaCorrente(int numeroConta, int saldoInicial) : base(numeroConta,saldoInicial){
            
        }
        public override void Creditar(int valor){
            saldo -= valor;
        }

        public void Sacar(int valor){
            if(saldo >= valor) Console.WriteLine($"Saque de {valor} realizado com sucesso");

            else Console.WriteLine("Saldo insuficiente !");
            
        }
    }
}