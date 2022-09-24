using System;
class Cronometro {
  static void Main() {
     int Horas,Minutos,Segundos,Total,Th,Tm;
        
        Console.WriteLine ("Digite as horas:");
        Horas = int.Parse(Console.ReadLine());
        
        Console.WriteLine ("Digite os minutos:");
        Minutos= int.Parse(Console.ReadLine());
        
        Console.WriteLine ("Digite os segundos:");
        Segundos = int.Parse(Console.ReadLine());
        
       Th = Horas * 3600;
       
       Tm = Minutos * 60;
       
       Total = Th + Tm + Segundos;

        Console.WriteLine($"O total de segundos é {Total}");
  }
}
