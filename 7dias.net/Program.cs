// Abaixo segue um exemplo de código que você pode ou não utilizar
using System;

class DIO {

  static void Main(string[] args) {

    double pi, raio, volume;
    pi = 3.14159;
 //TODO: Complete os espaços em branco com uma possível solução para o desafio     
    // raio = double.Parse(Console.ReadLine());
    raio = 1523;
    volume = (4/3.0) * pi  * Math.Pow( raio , 3 );
    volume = Math.Round(volume,3);
  
    Console.WriteLine($"VOLUME = {volume}");

    
    
  }

}