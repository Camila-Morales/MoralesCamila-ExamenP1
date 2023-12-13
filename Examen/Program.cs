using System;

static class Program
{
    //MAIN PROGRAM 
    public static void Main(string[] args) {
        Console.WriteLine("Ejercicio 1);  
        Ejercicio1(); 
                          
        Console.WriteLine("Ejercicio 2);                    
        Ejercicio2();
                          
        Console.WriteLine("Ejercicio 3);                    
        Ejercicio3();

        Console.WriteLine("Ejercicio 4);                    
        Ejercicio4(); 

        Console.WriteLine("Ejercicio 5);                    
        Ejercicio5();        
    }

//////////////////////////////////////////////////////////////////////////////////////////////////////

/// EJERCICIOS 

    /*
    Ejercicio 1: Variables y Operadores en C#
    1. Declarar dos variables, numero1 y numero2, e inicialízalas con valores numéricos.
    2. Calcula la suma de estas dos variables y almacena el resultado en una tercera
    variable llamada resultado.
    3. Imprime en la consola el valor de resultado.
    */
    
    public static void Ejercicio1()
    {
        //Declaramos variables 
        int numero1 = 7;
        int numero2 = 10;
        

        //Calcular la suma de las variables
        int resultado = numero1 + numero2;

        Console.WriteLine("El resultado de la suma es: "+ resultado);        
    }


    /*
    Ejercicio 2: Estructuras de Control en C#
    1. Declara una variable edad e inicialízala con un valor numérico.
    2. Utiliza una estructura if para determinar si la persona es mayor de edad (mayor o
    igual a 18).
    3. Imprime en la consola un mensaje indicando si la persona es mayor de edad o no.
    */
    public static void Ejercicio2()
    {
        //Declaramos variables 
        int edad = 21;

        //Estructura IF
        if (edad > 18)
        {
            Console.WriteLine("La persona ES mayor de edad");
        }
        else
        {
            Console.WriteLine("La persona NO ES mayor de edad");
        }      
    }


    /*
    Ejercicio 3: Programación Orientada a Objetos - Clases y Objetos
    1. Crea una clase llamada Estudiante con propiedades como Nombre, Edad y
    Calificacion.
    2. Crea un objeto de tipo Estudiante llamado estudiante1 e inicializa sus
    propiedades con valores ficticios.
    3. Imprime en la consola la información del estudiante.
    */
    public static void Ejercicio3()
    {
        //Objeto 
        Estudiante estudiante1 = new Estudiante
        {
            nombre = "Camila", 
            edad = 21,
            calificacion = 9.5f
        };

        Console.WriteLine("El nombre del estudiante es: " + estudiante1.nombre);
        Console.WriteLine("La edad del estudiante es: " + estudiante1.edad);
        Console.WriteLine("La calificacion del estudiante es: " + estudiante1.calificacion);
    }


    /*
    Ejercicio 4: Programación Orientada a Objetos - Métodos
    1. Amplía la clase Estudiante con un método llamado MostrarInformacion que
    imprima en la consola los detalles del estudiante.
    2. Llama al método MostrarInformacion para el objeto estudiante1 y observa la
    salida.
    */
    public static void Ejercicio4()
    {
        //Objeto 
        Estudiante estudiante1 = new Estudiante
        {
            nombre = "Camila", 
            edad = 21,
            calificacion = 9.5f
        };

        estudiante1.MostrarInformacion();
    }


    /*
    Ejercicio 5: Programación Orientada a Objetos - Herencia
    1. Crea una nueva clase llamada EstudianteGraduado que herede de la clase
    Estudiante.
    2. Añade una nueva propiedad a EstudianteGraduado llamada Titulo que
    almacene el título obtenido.
    3. Crea un objeto de tipo EstudianteGraduado llamado graduado1 e inicializa sus
    propiedades.
    4. Utiliza el método MostrarInformacion de la clase base para mostrar la
    información del estudiante graduado.
    */
    public static void Ejercicio5()
    {
        //Objeto 
        EstudianteGraduado graduado1 = new EstudianteGraduado
        {
            nombre = "Sophie", 
            edad = 20,
            calificacion = 9.2f,
            titulo = "Ingeniera en telecomunicacion"
        };

        graduado1.MostrarInformacion();
    }     
}

