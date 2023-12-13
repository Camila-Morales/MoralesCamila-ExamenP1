//1. Crea una clase llamada Estudiante con propiedades como Nombre, Edad y Calificacion.

using System;

class Estudiante
{
    //Propiedades 
    public string nombre { get; set; } = "";
    public int edad { get; set; }

    public float calificacion { get; set; }

    //1. Amplía la clase Estudiante con un método llamado MostrarInformacion que imprima en la consola los detalles del estudiante.
    public virtual void MostrarInformacion(){
        Console.WriteLine("El nombre del estudiante es: " + nombre + "\n"
         + "La edad del estudiante: " + edad + "\n" 
         + "La calificacion del estudiante: " + calificacion);
    }
}


