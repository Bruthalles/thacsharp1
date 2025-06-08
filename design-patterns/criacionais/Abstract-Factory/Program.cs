class Program{
    static void Main(string[] args){
        Console.Write("\nEscolha o tema claro/escuro: ");
        string? escolha = Console.ReadLine();

        IGUIFactory factory;

        if ( escolha == "claro"){
            factory = new TemaClaroFactory();
        }
        else{
            factory = new TemaEscuroFactory();
        }

        Aplicacao app = new Aplicacao(factory);
        app.RenderizarInterface();
    }
}