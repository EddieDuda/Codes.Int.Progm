using System;

namespace jp{
class IDADE_NADADOR {
  static void Main() {
    int Idade;
    Console.WriteLine ("Digite a idade:");
    Idade = int.Parse(Console.ReadLine());
    
    if ((Idade < 18))
    {
            if ((Idade >= 14) && (Idade <=17))
            {
              Console.WriteLine("Sua categoria é Juvenil B");
            } 
            
            if ((Idade >= 13) && (Idade <=11))
            {
              Console.WriteLine("Sua categoria é Juvenil A");
            } 
            
            if ((Idade >= 8) && (Idade <=10))
            {
              Console.WriteLine("Sua categoria é Juvenil A");
            }        
         
         
    } else 
       Console.WriteLine("Sua categoria é Senior!"); 
    
  }
 }
}
