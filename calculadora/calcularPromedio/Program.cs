using System;

namespace calcularPromedio
{
    class Program
    {
        static void Main(string[] args)
        {
            /*5. Hacer un programa para ingresar por teclado las tres notas de exámenes de un alumno 
            y luego calcule y emita por pantalla el promedio final. */

            //Variables
            const int CantidadNotas = 3;
            int nota1, nota2, nota3;
            float promedio;

            //pedimos las notas de los alumnos
            Console.WriteLine("Ingrese la primer nota del alumno: ");
            nota1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la segunda nota del alumno: ");
            nota2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la tercer nota del alumno: ");
            nota3 = int.Parse(Console.ReadLine());

            //calculamos el promedio de las notas
            promedio = (float)(nota1 + nota2+ nota3) / CantidadNotas;

            //Mostramos el promedio del alumno
            Console.WriteLine("El promedio del alumno es: " + promedio);
        }
    }
}
