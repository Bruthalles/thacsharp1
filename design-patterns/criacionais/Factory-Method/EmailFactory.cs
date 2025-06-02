using Inotf;
public class EmailFactory : NotifcFactory{
    public override INotificacao CriarNotificacao(){
        return new NotificacaoEmail();
    }
}