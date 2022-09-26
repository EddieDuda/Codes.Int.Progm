using System;
class DinheiroReverso {
  static void Main() {
    int notas1=0, notas5=0, notas10=0, notas50=0, notas100=0, valor;  
    Console.WriteLine("Olá, caro(a) cliente, responda a questão abaixo:");
    Console.WriteLine("Digite o valor total do dinheiro:");
    valor = int.Parse(Console.ReadLine());
   

    if (valor >= 100){
        notas100 = valor/100;
        notas50 = (valor%100) / 50;
        notas10 = ((valor%100) % 50) / 10;
        notas5 = (((valor%100) % 50) % 10) / 5;
        notas1 = ((((valor%100) % 50) % 10) % 5) /1;
        
    }else if(valor >= 50 && valor < 100){
        notas50 = valor/50;
        notas10 = (valor%50) / 10;
        notas5 = ((valor%50) % 10) / 5;
        notas1 = (((valor%50) % 10) % 5) / 1;
   }else if(valor >= 10 && valor < 100){
        notas10 = valor/10;
        notas5 = (valor%10) / 5;
        notas1 = ((valor%10) % 5) / 1;
    }else if(valor >= 5 && valor < 100){
        notas5 = valor/5;
        notas1 = (valor%5) / 1;
    }else{
        notas1 = valor/1;
    }
    Console.WriteLine($"Notas de 100 : {notas100}");
    Console.WriteLine($"Notas de 50 : {notas50}");
    Console.WriteLine($"Notas de 10 : {notas10}");
    Console.WriteLine($"Notas de 5 : {notas5}");
    Console.WriteLine($"Notas de 1 : {notas1}");
    
  }
} 
