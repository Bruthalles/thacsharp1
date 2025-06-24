using bootcamp.models;

namespace bootcamp.models{

    public abstract class Conta{
        public Conta(int numeroConta, int saldoInicial){
            NumeroConta = numeroConta;
            saldo = saldoInicial;
            
        }
        public int NumeroConta { get; set;}
        protected decimal saldo;

        public void ExibirSaldo(){
            Console.WriteLine("Seu saldo é : ", saldo);
        }

        public abstract void Creditar(int valor);
    }
}