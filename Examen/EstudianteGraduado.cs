// 1. Crea una nueva clase llamada EstudianteGraduado que herede de la clase Estudiante.
// 2. Añade una nueva propiedad a EstudianteGraduado llamada Titulo que almacene el título obtenido.

using System;

class EstudianteGraduado:Estudiante{
    //Propiedad
    public string titulo { get; set; } = "";

    public override void MostrarInformacion()
    {
        base.MostrarInformacion();
        Console.WriteLine("El titulo del estudiante es;" + titulo);
    }

}