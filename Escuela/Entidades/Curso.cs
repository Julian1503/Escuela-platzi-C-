using System;
using System.Collections.Generic;
using System.Text;
using Escuela.App;

namespace Escuela.Entidades
{
   public class Curso
    {
        public string Nombre { get;  set; }
        public string Id { get; private set; }
        public Jornada Jornada { get; set; }
        public List<Asignatura> Asignaturas { get; set; }
        public List<Alumno> Alumnos { get; set; }
        public Curso()=> Id = Guid.NewGuid().ToString();

    }
}
