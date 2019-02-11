using System;
using System.Collections.Generic;

namespace Escuela.Entidades
{
    public class Escuela
    {

        public Escuela(string nom, TiposEscuela tipo, int año, string pais = "", string prov = "")
        {
            (Nombre, Tipo, AñoCreacion,  Pais, Provincia) = (nom, tipo, año,  pais, prov);
        }
        public string Nombre { get; set; }

        public string Provincia { get; set; }

        public string Pais { get; set; }

        public List<Curso> Cursos { get; set; }

        public int AñoCreacion { get; set; }

        public TiposEscuela Tipo { get; set; }

        public override string ToString()
        {
           return $"Alumno: {Nombre} Año de Creacion: {AñoCreacion} {Environment.NewLine}" +
                   $"Tipo: {Tipo} {Environment.NewLine}" +
                   $"Pais: {Pais} Provincia: {Provincia}";
        }


    }
}
