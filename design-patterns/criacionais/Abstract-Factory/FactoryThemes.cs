public class TemaEscuroFactory : IGUIFactory{
    public IBotao CriarBotao(){
        return new BotaoEscuro();
    }

    public ICheckBox CriarCheckBox(){
        return new CheckBoxEscuro();
    }
}

public class TemaClaroFactory : IGUIFactory{
    public IBotao CriarBotao(){
        return new BotaoClaro();
    }
    public ICheckBox CriarCheckBox(){
        return new CheckBoxClaro();
    }
}