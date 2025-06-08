public class BotaoClaro : IBotao{
    public void Renderizar(){
        Console.WriteLine("Renderizando botao claro");
    }
}

public class CheckBoxClaro : ICheckBox{
    public void Marcar(){
        Console.WriteLine("Marcando checkbox claro");
    }
}