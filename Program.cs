namespace sistemaCalificaciones;

class Program
{
    static void Main(string[] args)
    {
        
        /*Solicitar al usuario una calificación entre 0 y 100.
           
           Validar que la calificación esté dentro del rango permitido.
           
           Mostrar A, B, C, D o F según el resultado.
           
           Indicar además si el estudiante aprobó o reprobó.
           
           Reto: mostrar un mensaje especial cuando obtenga 100.*/
        
        // nombre del programa
        Console.WriteLine("\tSISTEMA DE CALIFICACION");
        
        // requerimiento de nombre de usuario
        Console.WriteLine("Cual es tu nombre? ");
        string? nombre = Console.ReadLine();
        
        // saludo a usuario
        Console.WriteLine($"\n*** Bienvenido/a al Sistema de Calificación {nombre} ***");
        
        // variables
        string respuesta = "";
        
        // Loop While
        while (respuesta != "N")
        {
            // requerimiento de nota al usuario
            Console.WriteLine("\nInserta tu calificación para devolver el valor literal:");
            int nota = int.Parse(Console.ReadLine());
            
            // comparacion de notas para resultado
            if (nota >= 90) // A
            {
                Console.WriteLine("***************************************");
                Console.WriteLine($"Tu nota es {nota} = A");
                Console.WriteLine($"Excelente! Felicidades {nombre}, aprobaste!");
                Console.WriteLine("***************************************");
            }
            else if (nota >= 80 && nota < 90) // B
            {
                Console.WriteLine("***************************************");
                Console.WriteLine($"Tu nota es {nota} = B");
                Console.WriteLine($"Muy bien! {nombre}, aprobaste!");
                Console.WriteLine("***************************************");
            }
            else if (nota >= 70 && nota < 80) // C
            {
                Console.WriteLine("***************************************");
                Console.WriteLine($"Tu nota es {nota} = C");
                Console.WriteLine($"Buen trabajo! {nombre}, aprobaste!");
                Console.WriteLine("***************************************");
            }
            else if (nota >= 60 && nota < 70) // D
            {
                Console.WriteLine("***************************************");
                Console.WriteLine($"Tu nota es {nota} = D");
                Console.WriteLine($"Puedes hacerlo mejor {nombre}, apúrate más!");
                Console.WriteLine("***************************************");
            }
            else
            {
                Console.WriteLine("***************************************");
                Console.WriteLine($"\nTu nota es {nota} = F"); // F
                Console.WriteLine($"Lo siento {nombre}, reprobaste!");
                Console.WriteLine("***************************************");
            }
            
            // desicion para continuar o no
            Console.WriteLine("\nDeseas saber otra calificación? S/N");
            respuesta = Console.ReadLine().ToUpper();

           
        }
        // mensaje final para cerrar programa
        Console.WriteLine("Gracias por utilizar Sistema de Calificación!");

    }
}
