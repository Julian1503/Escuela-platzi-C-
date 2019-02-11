using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Escuela.App
{
   public static class CalificacionAzar
    {
        public static decimal CargarNotaAzar(int min, int max)
        {
            Random rnd = new Random();
            return rnd.Next(min,max+1) / 10m;
        }
    }
}
