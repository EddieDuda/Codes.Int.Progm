using System;
namespace SampleWhile
{
	public class Soma_Impar_Entre_A_B
  {	
		static void Main(string[] args)
		{
      int A,B, i, Soma = 0;
      Console.WriteLine ("Digite um número inteiro:");
      A = int.Parse(Console.ReadLine());
      Console.WriteLine ("Digite outro número inteiro:");
      B = int.Parse(Console.ReadLine());
      
      if ((A % 2) == 0)
      {
       for (i = A + 1; i > A && i < B; i = i +2 ) 
       Soma = Soma + i;
       Console.WriteLine ($"{Soma}");
      
          
      } else 
		{
       for (i = A + 2; i > A && i < B; i = i + 2 )
       Soma = Soma + i;
       Console.WriteLine ($"{Soma}");
	    }
      
      
      
	 
   } 
  }
}
