using System;
class Dinheiro {
  static void Main() {
    int notas1, notas5, notas10, notas50, notas100, total;  
    Console.WriteLine("Olá, caro(a) cliente, responda as questões abaixo:");
    Console.WriteLine("Quantas notas de um 1 real tem no bolo?");
    notas1 = int.Parse(Console.ReadLine());
    Console.WriteLine("Quantas notas de 5 reais tem no bolo?");
    notas5 = int.Parse(Console.ReadLine());
    Console.WriteLine("Quantas notas de 10 reais tem no bolo?");
    notas10 = int.Parse(Console.ReadLine());    
    Console.WriteLine("Quantas notas de 50 reais tem no bolo?");
    notas50 = int.Parse(Console.ReadLine());    
    Console.WriteLine("Quantas notas de 100 reais tem no bolo?");
    notas100 = int.Parse(Console.ReadLine());

    if ((notas1>0) & (notas5>0) & (notas10>0) & (notas50>0) & (notas100>0))
    {
        total = notas1 + (notas5 * 5) + (notas10 * 10) + (notas50 * 50) + (notas100 * 100);
        Console.WriteLine($"Você tem {total} reais ");    
          
            if((notas1>0) & (notas5>0) & (notas10>0) & (notas50>0) & (notas100==0))
            {
              total = notas1 + (notas5 * 5) + (notas10 * 10) + (notas50 * 50);
              Console.WriteLine($"Você tem {total} reais ");
            } 

            if((notas1>0) & (notas5>0) & (notas10>0) & (notas50==0) & (notas100==0))
            {
              total = notas1 + (notas5 * 5) + (notas10 * 10);
              Console.WriteLine($"Você tem {total} reais ");
            } 

            if((notas1>0) & (notas5>0) & (notas10==0) & (notas50==0) & (notas100==0))
            {
              total = notas1 + (notas5 * 5);
              Console.WriteLine($"Você tem {total} reais ");
            }        
            
            if((notas1>0) & (notas5==0) & (notas10==0) & (notas50==0) & (notas100==0))
            {
              total = notas1 ;
              Console.WriteLine($"Você tem {total} reais ");
            }
             
            
    }else
                    Console.WriteLine($"Você tem 0 reais "); 
  }
}                           
    
