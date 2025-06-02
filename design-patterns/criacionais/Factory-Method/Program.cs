using Inotf;
using static System.Console;

class Program{
    static void Main(string[] args){
        NotifcFactory factory;
        Write("\nDigite o tipo de notificacao (email/SMS): ");
        string tipo = ReadLine();

        if (tipo == "email"){
            factory = new EmailFactory();
        }
        else if (tipo == "sms"){
            factory = new SMSFactory();
        }
        else{
            WriteLine("TIpo invalido");
            return;
        }
        INotificacao notificacao = factory.CriarNotificacao();
        notificacao.Enviar("ola, mensagem enviada");


    }
}