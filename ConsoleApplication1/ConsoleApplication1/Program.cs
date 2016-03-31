using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero=0;
            
            Alumno UnAlumno;//UnAlumno es el objeto de la clase Alumno. Solo el objeto accede a la instancia 
                            // nombre de la clase alumno.

            UnAlumno=new Alumno(666);//Esto crea un nuevo objeto y lo ubica en un lugar x de la memoria;
            //UnAlumno.nombre = "Facundo"; pasamos a privado el nombre
            //UnAlumno.legajo = 0;// pasamos el public int legajo  a private desde la clase alumno.


            //Para acceder a un atributo privado 3 formas:
            //1- A traves de un constructor.(Cualqueier Lenguaje)
            //2- A traves de un metodo (GetVariable para asignar // SetVariable para mostrar) .(Cualqueier Lenguaje) 
            //3- A traves de Propipedades.(Ver definicion).

            UnAlumno.GetLegajo(); //2-//
            UnAlumno.SetNombre("Facundo");
            //Console.WriteLine("Nombre del alumno: " + UnAlumno.nombre);
            //Console.ReadKey();

            UnAlumno.mostrar();// Mostramos mediante el metodo de la clase
            
            Console.ReadKey();

            Rueda UnaRueda = new Rueda();
            Auto Auto1 = new Auto("fiat");
            Auto Auto2 = new Auto("fiat");
            Auto Auto3 = new Auto("fiat"); 
        } 
    }
}
