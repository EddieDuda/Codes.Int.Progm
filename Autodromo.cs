using System;
class Autodromo {
  static void Main() {
    double velocidade_media1,velocidade_media2,comprimento_pista;
    int velocidade_carro1,velocidade_carro2;
    
    Console.WriteLine("Olá, caro(a) cliente, primeiro:");
    Console.WriteLine("Digite o comprimento da pista em metros:");
    comprimento_pista = int.Parse(Console.ReadLine());
    Console.WriteLine("Agora em segundos:");
    Console.WriteLine("Digite a velocidade do primeiro carro");
    velocidade_carro1 = int.Parse(Console.ReadLine());
    Console.WriteLine("Digite a velocidade do segundo carro");
    velocidade_carro2 = int.Parse(Console.ReadLine());    

    velocidade_media1 = comprimento_pista / velocidade_carro1;
    
    velocidade_media2 = comprimento_pista / velocidade_carro2;

    if (velocidade_media1 > velocidade_media2 )
    {
        Console.WriteLine($"O primeiro carro é o mais rápido.");    
    }else
         Console.WriteLine($"O segundo carro é mais rápido"); 
  }
}  
