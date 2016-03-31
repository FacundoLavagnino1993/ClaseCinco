using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Alumno
    {
        public Alumno(int legajo)
        {
            this.nombre = "fafafa";
            this.legajo = legajo;
        }

        private int legajo;
        private string nombre; //Estructura del objeto.
                              // Un objeto es una instancia de la clase.  
        public void mostrar() // Creamos un metodo para mostrar el nombre. Es importante colocar el "this."
                              // 
        {
            Console.Write(this.nombre + this.legajo);
           
        }

        private bool Comparame(Alumno UnAlumno)     // Creamos un metodo para comparar nombres, recibe un objeto de tipo Alumno
        {
            bool respuesta = false;
            if (this.nombre == UnAlumno.nombre && this.legajo == UnAlumno.legajo) // Comparamos el nombre y el legajo
            {
                respuesta = true;

            }
            return respuesta;
        }

        public int GetLegajo()// Metodo para acceder a un atributo privado. Retornar un "Legajo" privado.
        {
            
            return this.legajo;
        }
        
        public void SetNombre(string Nombre) //Metodo para tomar un atributo privado. Toma "nombre"
        {
            this.nombre = Nombre;
        }

        public static bool CompararDosAlumnos(Alumno alumno, Alumno alumnoDos)
        {
            bool respuesta = false;
            
          

            if (alumno.nombre == alumnoDos.nombre && alumno.legajo == alumnoDos.legajo)
            {
                respuesta = true;
            }

            return respuesta;
        }
        public static void mostrarAlumno(Alumno alumno)
        {
            Console.WriteLine(alumno.nombre);
            Console.ReadKey();
        }
    }
}
