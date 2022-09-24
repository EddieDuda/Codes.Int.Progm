using System;
class Dias {
  static void Main() {
    int Dia1,Mes1,Ano1;
    int Dia2,Mes2,Ano2;
    int TDias,TMeses,TAnos;
    
        Console.WriteLine ("Digite o dia da primeira data:");
        Dia1 = int.Parse(Console.ReadLine());
        
        Console.WriteLine ("Digite o mês da primeira data:");
        Mes1 = int.Parse(Console.ReadLine());
        
        Console.WriteLine ("Digite o ano da primeira data:");
        Ano1 = int.Parse(Console.ReadLine());
     
        Console.WriteLine ("Digite o dia da segunda data (não pode ser menos que a primeira data):");
        Dia2 = int.Parse(Console.ReadLine());
        
        Console.WriteLine ("Digite o mês da segunda data(não pode ser menos que a primeira data):");
        Mes2 = int.Parse(Console.ReadLine());
        
        Console.WriteLine ("Digite o ano da segunda data(não pode ser menos que a primeira data):");
        Ano2 = int.Parse(Console.ReadLine());
    
      TAnos = Ano2 - Ano1;
      
      TMeses = TAnos * 12 + ( Mes2 - Mes1);
      
      TDias = TMeses * 30 + ( Dia2 - Dia1);
        
        Console.WriteLine($"A diferença total de anos entre as duas datas é:{TAnos}");
        Console.WriteLine($"A diferença total de meses entre as duas datas é:{TMeses}");
        Console.WriteLine($"A diferença total de dias entre as duas datas é:{TDias}");
  }
}
