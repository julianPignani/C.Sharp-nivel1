using System;

namespace ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. Hacer un programa para ingresar un número y luego se emita por pantalla un cartel aclaratorio
            // si “Es mayor a 10” o “No es mayor a 10”.

            //declaramos las variables
            int num;

            //pedimos los datos al usuario
            Console.WriteLine("Ingrese un número: ");
            num = int.Parse(Console.ReadLine());

            //realizamos la condición 
            if(num > 10)
                Console.WriteLine("El número ingresado es mayor a 10");
            else
                Console.WriteLine("El número ingresado no es mayor a 10");
        }
    }
}
