using System;
class Num_Inteiros {
  static void Main() {
    int Pn, Sn, Tn;
    int MArit,ProdNum,SNum;
    
    Console.WriteLine ("Digite o primeiro número:");
    Pn = int.Parse(Console.ReadLine());
    
    Console.WriteLine ("Digite o segundo número:");
    Sn = int.Parse(Console.ReadLine());

    Console.WriteLine ("Digite o terceiro número:");
    Tn = int.Parse(Console.ReadLine());
    
    MArit = (Pn + Sn + Tn) / 3;
    
    SNum = Pn + Sn + Tn;
    
    ProdNum = Pn * Sn * Tn;
    
    Console.WriteLine($"A média aritmética dos números digitados é: {MArit}");
    Console.WriteLine($"O somatório dos númeors digitados é: {SNum}");
    Console.WriteLine($"O produtório dos números digitados é:{ProdNum}");


  }
}
