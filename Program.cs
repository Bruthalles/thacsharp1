using System;



class Cliente{

    string nome = "";
    int idade = 0 ;
    static void Main(string[] args){

         /* function convertint(int atributo){
            atributo = Console.WriteLine(Convert.ToString(atributo));
            return atributo;
        }  */
        
        Cliente pessoa = new Cliente();

        Console.WriteLine("digite nome: ");
        pessoa.nome = Console.ReadLine();
        
        
        Console.WriteLine("digite sua idade: ");
        
        Convert.ToString(pessoa.idade);
        pessoa.idade =Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("olá "+ pessoa.nome + ", com " + pessoa.idade + " anos" );

        Console.WriteLine("hello");
    }
}
