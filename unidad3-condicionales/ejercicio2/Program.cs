using System;

namespace ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 2. Hacer un programa para ingresar un número y luego se emita un cartel por pantalla “Positivo”
             si el número es mayor a cero, “Negativo” si el número es menor a cero o “Cero” si el número es 
             igual a cero.*/

            //Declaramos variable
            int numero;

            //pedimos datos al usuario
            Console.WriteLine("Ingrese un número: ");
            numero = int.Parse(Console.ReadLine());

            //Condición
            if(numero > 0)
                Console.WriteLine("El número es Positivo!!");
            else if(numero == 0)
                Console.WriteLine("El número es igual a 0");
            else 
                Console.WriteLine("El número es negativo!");     
        }
    }
}
