public class Aplicacao{
    private readonly IBotao _botao;
    private readonly ICheckBox _checkbox;

    public Aplicacao(IGUIFactory factory){
        _botao = factory.CriarBotao();
        _checkbox = factory.CriarCheckBox();
    }

    public void RenderizarInterface(){
        _botao.Renderizar();
        _checkbox.Marcar();
    }
}