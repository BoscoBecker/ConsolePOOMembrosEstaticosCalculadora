﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ConsolePOOMembrosEstaticosCalculadora.Entidade
{
  internal class Calculadora
  {
    public static double Pi = 3.14;
    public static double Circuferencia(double raio) { 
      return 2.0 *  Pi * raio;
    }
    public static double Volume(double raio) {
      return 4.0 / 3.0 * Pi * Math.Pow(3.0, raio);
    } 
  }
}
