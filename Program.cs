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
        
        Console.WriteLine("\tSISTEMA DE CALIFICACION");
        
        
        Console.WriteLine("Cual es tu nombre? ");
        string? nombre = Console.ReadLine(); //leer nombre
        
        Console.WriteLine($"\nBienvenido/a al Sistema de Calificación {nombre}"); // escribir saludo y nombre
        Console.WriteLine("\nInserta tu calificación para devolver el valor literal:");
        decimal nota = 0m;
        string respuesta = "N";
        
        while (respuesta == "S")
        {

            nota = decimal.Parse(Console.ReadLine());

            if (nota >= 90)
            {
                Console.WriteLine($"Tu nota es {nota} = A");
                Console.WriteLine($"Excelente! Felicidades {nombre}, aprobaste!");
            }
            else if (nota >= 80 && nota < 90)
            {
                Console.WriteLine($"Tu nota es {nota} = B");
                Console.WriteLine($"Muy bien! {nombre}, aprobaste!");
            }
            else if (nota >= 70 && nota < 80)
            {
                Console.WriteLine($"Tu nota es {nota} = C");
                Console.WriteLine($"Buen trabajo! {nombre}, aprobaste!");
            }
            else if (nota >= 60 && nota < 70)
            {
                Console.WriteLine($"Tu nota es {nota} = D");
                Console.WriteLine($"Puedes hacerlo mejor {nombre}, apúrate más!");
            }
            else
            {
                Console.WriteLine($"Tu nota es {nota} = F");
                Console.WriteLine($"Lo siento {nombre}, reprobaste!");
            }
            
            Console.WriteLine("Deseas saber otra calificación? S/N");
            respuesta = Console.ReadLine();

           
        }

    }
}
