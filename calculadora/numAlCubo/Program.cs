using System;

namespace numAlCubo
{
    class Program
    {
        static void Main(string[] args)
        {
          //2. Hacer un programa para solicitar por teclado un número y luego devolver su valor elevado al cubo.
          //declaramos la variables
          int num, resultado;

          //Pedimos un número
          Console.WriteLine("Ingrese un número: ");
          num = int.Parse(Console.ReadLine());

          //Elevamos al cubo
          resultado = (num * num * num);

          //Mostramos el valor
          Console.WriteLine("El " + num + " elevado al cubo es: " + resultado);
            
        }
    }
}
