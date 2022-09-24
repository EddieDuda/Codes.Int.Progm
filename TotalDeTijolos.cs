using System;
class Total_Tijolos {
  static void Main() {
     float AltParede,LargParede,AParede;
     float AltJanela, LargJanela,AJanela;
     float AltPorta,LargPorta,APorta;
     float AltTijolo,LargTijolo,ATijolo;
     float Asala,DSALA, Total;
        
        Console.WriteLine ("Digite Altura da Parede:");
        AltParede = float.Parse(Console.ReadLine());
        
        Console.WriteLine ("Digite Largura da Parede:");
        LargParede = float.Parse(Console.ReadLine());
        
        Console.WriteLine ("Digite Altura da Janela:");
        AltJanela = float.Parse(Console.ReadLine());
        
        Console.WriteLine ("Digite Largura da Janela:");
        LargJanela = float.Parse(Console.ReadLine());
        
        Console.WriteLine ("Digite Altura da Porta:");
        AltPorta = float.Parse(Console.ReadLine());
        
        Console.WriteLine ("Digite Largura da Porta:");
        LargPorta = float.Parse(Console.ReadLine());
        
        Console.WriteLine ("Digite Altura do Tijolo:");
        AltTijolo = float.Parse(Console.ReadLine());
        
        Console.WriteLine ("Digite Largura do Tijolo:");
        LargTijolo = float.Parse(Console.ReadLine());
        
        AParede = AltParede * LargParede;
        ATijolo = AltTijolo * LargTijolo;
        AJanela = AltJanela * LargJanela;
        APorta = AltPorta * LargPorta;
        Asala = AParede *4;
        DSALA = Asala - (AJanela + APorta);
        Total = DSALA / ATijolo;
        
        Console.WriteLine($"O total de tijolos nesessários é:{Total}");
  }
