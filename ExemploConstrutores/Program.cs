using System;
using ExemploConstrutores.Models;

namespace ExemploConstutores
{
  class Program
  {
    static void Main(string[] args)
    {
      // Log log = Log.GetInstance();

      // log.PropriedadeLog = "Teste instancia";

      // Log log2 = Log.GetInstance();
      // System.Console.WriteLine(log2.PropriedadeLog);

      Pessoa p1 = new Pessoa("Evelym", "Pereira");
      p1.Apresentar();

      Aluno a1 = new Aluno("Camile", "da Silva", "Matemática");
      a1.Apresentar();
    }
  }
}
