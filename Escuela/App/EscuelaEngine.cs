using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using Escuela.Entidades;
namespace Escuela.App
{
    public class EscuelaEngine
    {
        public Entidades.Escuela Escuela { get; set; }
        
        public void Inicializar()
        {
            Escuela = new Entidades.Escuela("Platzi", TiposEscuela.Primaria, 1923, "Colombia", "Bogota");
            CargarCursos();     
            CargarAsignaturas();
            CargarEvaluaciones();
        }

        private void CargarEvaluaciones()
        {
           foreach (var i in Escuela.Cursos)
            {
                foreach (var o in i.Alumnos)
                {
                    foreach (var p in i.Asignaturas)
                    {
                        for (int j = 0; j < (i.Asignaturas.Count*5); j++)
                        {
                            p.Evaluaciones.Add(new Evaluacion
                            {
                                Alumno = o,
                                Nota = CalificacionAzar.CargarNotaAzar(0,50)
                            });
                        }
                    }
                }
            }
        }

        private void CargarAsignaturas()
        {
            List<Asignatura> asig = new List<Asignatura>
            {
                new Asignatura
                {
                    Nombre = "Matematica"
                },
                new Asignatura
                {
                    Nombre = "Educacion Fisica"
                },
                new Asignatura
                {
                    Nombre = "Castellano"
                },
                new Asignatura
                {
                    Nombre = "Ciencias Naturales"
                }
            };
            foreach (var cursos in Escuela.Cursos)
            {
               
                cursos.Asignaturas =(asig);
            }
        }

        private List<Alumno> CargarAlumnos(int cantidad)
        {
            string[] nombres1 = {"Marcianito", "Paula", "Julian", "Santiago", "Benjamin", "Eduardo", "Adriana"};
            string[] nombres2 = {"Alejandro", "Mariano", "Mauricio", "Martina", "Tomas", "Ismael", "Mateo"};
            string[] apellidos = {"Trump", "Brown", "Brunella","Buezo","Teruel","Lascano","Delgado","Jandar"};
            var listaAlumnos = from n1 in nombres1
                from n2 in nombres2
                from ap in apellidos
                select new Alumno() {Nombre = $"{n1} {n2} {ap}"};
            return listaAlumnos.OrderBy(x=>x.Id).Take(cantidad).ToList();
        }

        private void CargarCursos()
        {
            var listaCursos = new List<Curso>
            {
                new Curso
                {
                    Nombre = "101",
                    Jornada = Jornada.Mañana
                },
                new Curso
                {
                    Nombre = "201",
                    Jornada = Jornada.Tarde
                },
                new Curso
                {
                    Nombre = "301",
                    Jornada = Jornada.Noche
                }
            };
            Escuela.Cursos = listaCursos;
            Random rnd = new Random();
            foreach (var cursos in Escuela.Cursos)
            {
                int cantidad = rnd.Next(10, 20);

                cursos.Alumnos = CargarAlumnos(cantidad);
            }
        }
    }
}
