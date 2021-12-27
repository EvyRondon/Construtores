namespace ExemploConstrutores.Models
{
  public class Calculadora
  {
    //Delegate
    public delegate void DelegateCalculadora();
    //Event delegate
    public static event DelegateCalculadora EventoCalculadora;
    public static void Somar(int valor1, int valor2)
    {
      if (EventoCalculadora != null)
      {
        System.Console.WriteLine($"Adição: {valor1 + valor2}");
        EventoCalculadora();
      }
      else
      {
        System.Console.WriteLine("Nenhum Inscrito");
      }
    }

    public static void Subtrair(int valor1, int valor2)
    {
      System.Console.WriteLine($"Subtração: {valor1 - valor2}");
    }
  }
}