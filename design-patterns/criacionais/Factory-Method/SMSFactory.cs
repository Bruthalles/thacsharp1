using Inotf;
public class SMSFactory : NotifcFactory{
    public override INotificacao CriarNotificacao(){
        return new NotificacaoSMS();
    }
}