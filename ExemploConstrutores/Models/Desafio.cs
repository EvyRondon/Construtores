using System;

namespace ExemploConstrutores.Models
{
  public class Desafio
  {
    public void Executar()
    {
      int limit = Int32.Parse(Console.ReadLine());
      for (int i = 0; i < limit; i++)
      {
        string[] line = Console.ReadLine().Split(" ");
        double X = double.Parse(line[0]);
        double Y = double.Parse(line[1]);
        if (X < 0 || Y < 0)
        {
          System.Console.WriteLine("divisao impossivell");

        }
        else
        {
          System.Console.WriteLine(X / Y);
        }
      }
    }
  }
}