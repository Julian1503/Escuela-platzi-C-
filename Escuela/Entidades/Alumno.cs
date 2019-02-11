using System;
using System.Xml;

namespace Escuela.App
{
    public class Alumno
    {
        public string Nombre { get; set; }
        public string Id { get; private set; }
        public Alumno() => Id= Guid.NewGuid().ToString();

        public override string ToString()
        {
            return Nombre;
        }
    }
}