using System;
class InteirosMaior {
  static void Main() {
    int numero1, numero2, numero3;  
    
    Console.WriteLine("Digite um numero:");
    numero1 = int.Parse(Console.ReadLine());
    Console.WriteLine("Digite um numero:");
    numero2 = int.Parse(Console.ReadLine());
    Console.WriteLine("Digite um numero:");
    numero3 = int.Parse(Console.ReadLine());
    

    if (numero1 > numero2 & numero1 > numero3){
       Console.WriteLine($"{numero1}");    
    }  
        
    if(numero2 > numero1 & numero2 > numero3){
    Console.WriteLine($"{numero2}");
    } 
    
    if(numero3 > numero1 & numero3 > numero2){
    Console.WriteLine($"{numero3}");
    } 
   
 }                           
}
