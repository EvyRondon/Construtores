using System;
using ExemploConstrutores.Models;

namespace ExemploConstutores
{
  class Program
  {
    public delegate void Operacao(int valor1, int valor2);
    static void Main(string[] args)
    {
      Matematica mt = new Matematica(10, 10);
      mt.Somar();
      // Delegate
      Operacao p1 = new Operacao(Calculadora.Somar);
      p1 += Calculadora.Subtrair;

      p1.Invoke(10, 10);

      // Operacao op = Calculadora.Somar;
      // op(10,10);

      // int limit = int.Parse(Console.ReadLine());
      // for (int i = 0; i < limit; i++)
      // {
      //   string[] line = Console.ReadLine().Split(" ");
      //   double X = double.Parse(line[0]);
      //   double Y = double.Parse(line[1]);
      //   if (Y < 0)
      //   {
      //     System.Console.WriteLine("divisao impossivel");

      //   }
      //   else
      //   {
      //     System.Console.WriteLine(X / Y);
      //   }
      // }

      // //Desafio papai noel
      // int N = int.Parse(Console.ReadLine());

      // //Exibir "Ho" do papai noel
      // for (int i = 0; i < N; i++)
      // {
      //   if (i < (N - 1))
      //   {
      //     Console.Write("Ho ");                  //Complete o código no espaço em branco
      //   }
      //   else
      //   {
      //     Console.WriteLine("Ho!");
      //   }
      // }

      // Log log = Log.GetInstance();

      // log.PropriedadeLog = "Teste instancia";

      // Log log2 = Log.GetInstance();
      // System.Console.WriteLine(log2.PropriedadeLog);

      // Pessoa p1 = new Pessoa("Evelym", "Pereira");
      // p1.Apresentar();

      // Aluno a1 = new Aluno("Camile", "da Silva", "Matemática");
      // a1.Apresentar();

      // Data dt = new Data();
      // // dt.Setmes(20);
      // dt.Mes = 20;
      // System.Console.WriteLine(dt.Mes);
      // dt.ApresentarMes();

    }
  }
}
