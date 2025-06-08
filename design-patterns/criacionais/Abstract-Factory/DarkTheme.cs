public class BotaoEscuro : IBotao{
    public void Renderizar(){
        Console.WriteLine("Renderizando botao escuro");
    }
}

public class CheckBoxEscuro : ICheckBox{
    public void Marcar(){
        Console.WriteLine("Marcando checkbox escuro");
    }
}