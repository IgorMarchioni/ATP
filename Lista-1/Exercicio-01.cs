using System;

class Program {
  public static void Main (string[] args) {
    double base1,altura,perimetro,area,diagonal; //variavel 
    Console.Write ("Digite a base do retangulo: "); // mostrar texto ao usuario
    base1 = double.Parse(Console.ReadLine()); // ler o valor digitado pelo usuario
    Console.Write("Digite a altura do retangulo: "); // mostrar texto ao usuario
    altura = double.Parse(Console.ReadLine()); // ler o valor digitado pelo usuario
    perimetro = 2 * (base1 + altura); // calculo do perimetro
    area = base1 * altura;// calculo da area
    diagonal = Math.Sqrt(Math.Pow(base1,2) + Math.Pow(altura,2)); // calculo da diagonal
    Console.Write("O perimetro do retangulo é {0}, sua area é {1} e sua diagonal é {2}",perimetro,area,diagonal);
    
    
    
  }
}
