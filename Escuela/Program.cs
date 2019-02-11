using System;
using System.Collections.Concurrent;
using Escuela.Entidades;
using System.Collections.Generic;
using Escuela.App;
using Escuela.Util;
using static System.Console;
using static Escuela.Util.Writer;


namespace Escuela
{
    class Program
    {
        static void Main(string[] args)
        {
            var escuela = new EscuelaEngine();
            escuela.Inicializar();
            Writer.ImprimirTitulo("BIENVENIDOS A LA ESCUELA");
            WriteLine(escuela.Escuela);
            escuela.Escuela.Cursos?.RemoveAll(x=>x.Nombre=="301");
            ImprimirCursos(escuela.Escuela);
            ImprimirAlumnos(escuela.Escuela.Cursos);
            ImprimirEvaluaciones(escuela.Escuela.Cursos);
            ReadKey();


        }

        private static void ImprimirCursos(Entidades.Escuela escuela)
        {
            if (escuela?.Cursos == null) return;
            Writer.ImprimirTitulo("Cursos de la escuela :");


            foreach (var i in escuela.Cursos)
            {
                WriteLine($"Alumno: {i.Nombre} {System.Environment.NewLine} Jornada: {i.Jornada} {System.Environment.NewLine} Id: {i.Id}");
            }

        }

        private static void ImprimirEvaluaciones(List<Curso> cursos)
        {
            foreach (var i in cursos)
            {
                foreach (var o in i.Asignaturas)
                {
                    foreach (var p in o.Evaluaciones)
                    {
                        WriteLine("Evaluacion de "+o.Nombre);
                        WriteLine(p.Alumno);
                        WriteLine(p.Nota);
                    }
                }
            }
        }
        private static void ImprimirAlumnos(List<Curso> cursos)
        {
            foreach (var cur in cursos)
            {
                Console.WriteLine($"Alumnos del curso \"{cur.Nombre}\" ");
                foreach (var a in cur.Alumnos)
                {
                    Writer.ImprimirTitulo($"Alumno: {a.Nombre} Id: {a.Id}");
                }
            }
        } 
    }
}
