using System;
using System.Globalization;
using ConsolePOOMembrosEstaticosCalculadora.Entidade;

namespace ConsolePOOMembrosEstaticosCalculadora
{
  internal class Program
  {
    static void Main(string[] args)
    {
      /// Calculadora calculadora = new Calculadora();
      /// Como agora os métodos são staticos não precisa instanciar...
      Console.Write("informe o raio: ");

      double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
      double circuferencia = Calculadora.Circuferencia(raio);
      double volume = Calculadora.Volume(raio);
      
      Console.WriteLine("Circuferência:" + circuferencia.ToString("F2",CultureInfo.InvariantCulture));
      Console.WriteLine("Volume:" + volume.ToString("F2", CultureInfo.InvariantCulture));
      Console.WriteLine("Pi:" + Calculadora.Pi.ToString("F2", CultureInfo.InvariantCulture));

    }
  }
}
