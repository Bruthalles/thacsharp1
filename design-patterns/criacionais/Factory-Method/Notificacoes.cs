using Inotf;
using static System.Console;
public class NotificacaoEmail : INotificacao {
    public void Enviar(string mensagem){
        WriteLine($"Enviando email: {mensagem}");
    }
}

public class NotificacaoSMS : INotificacao{
    public void Enviar(string mensagem){
        WriteLine($"Enviando SMS: {mensagem}");
    }
}