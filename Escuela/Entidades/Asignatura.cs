using System.Collections.Generic;
using Escuela.App;

namespace Escuela.Entidades
{
    public class Asignatura
    {
        public string Nombre { get; set; }
        public List<Evaluacion> Evaluaciones { get; set; }

        public Asignatura() => Evaluaciones = new List<Evaluacion>();
    }
}