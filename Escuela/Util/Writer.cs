using System;
using System.Collections.Generic;
using System.Text;

namespace Escuela.Util
{
    public static class Writer
    {
        public static void Linea(int tamaño=10)
        {
            string s = "".PadLeft(tamaño,'=');
            
            Console.WriteLine(s);
        }

        public static void ImprimirTitulo(string titulo)
        {
            int tamaño = titulo.Length + 6;
            Linea(tamaño);
            Console.WriteLine($"|| {titulo} ||");
            Linea(tamaño);
        }

        public static void HacerBeep(int hz = 1500, int tiempo = 2000, int cantidad = 3)
        {
            for (int i = 0; i < cantidad; i++)
            {
                Console.Beep(hz,tiempo);
            }
        }
    }
}
