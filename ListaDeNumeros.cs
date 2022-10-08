using System;
class lista_numeros {
  static void Main() {
    int numero, i;
      
    Console.WriteLine("Digita um numero entre 0 e 100:");
    numero = int.Parse(Console.ReadLine());

    for(i = 0; i <= 100; i++){
        Console.WriteLine(i);
        
        if(i == numero){
            break;
        }
    }   
      
  }
}
