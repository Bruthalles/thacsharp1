namespace heroclass;
public class Heroi{
    
    public string nome { get; set; }
    public string tipo { get; set; } 
    public string ataque { get; set; }    
    public void atacar(){
        
        Console.WriteLine($"O {this.tipo} atacou usando {this.ataque}");
    }  
}

public class Guerreiro : Heroi{
// ataque: espada
    public string nome = "Hercules";
    public string tipo = "Guerreiro";
    public string ataque = "Espada";
    public void atacar(){
        Console.WriteLine($"O {tipo} {nome} atacou usando {ataque}");
    }
}

public class Mago : Heroi{
// ataque: magia
    public string nome = "Patolino";
    public string tipo = "Mago";
    public string ataque = "Magia";
    public void atacar(){
        Console.WriteLine($"O {tipo} {nome} atacou usando {ataque}");
    }
}

public class Monge : Heroi{
// ataque: kung fu
    public string nome = "Aang";
    public string tipo = "Monge";
    public string ataque = "Kung Fu";
    public void atacar(){
        Console.WriteLine($"O {tipo} {nome} atacou usando {ataque}");
    }
    
}

public class Ninja : Heroi{
// ataque: shuriken
    public string nome = "Rafael";
    public string tipo = "Ninja";
    public string ataque = "Shuriken";
    public void atacar(){
        Console.WriteLine($"O {tipo} {nome} atacou usando {ataque}");
    }
    
}