using System;
class Latas_Tinta {
  static void Main() {
     double Altura, Largura, Area, Tinta, Latas; 
        Console.WriteLine ("Digite altura da parede:");
        Altura = double.Parse(Console.ReadLine());
        Console.WriteLine ("Digite largura da parede:");
        Largura = double.Parse(Console.ReadLine());
       Area = Largura * Altura;
       Tinta = Area * 0.3;
       Latas = Tinta / 2;
        Console.WriteLine($"Você precisa de {Latas} latas de tinta para pintar a parede.");
  }
}
