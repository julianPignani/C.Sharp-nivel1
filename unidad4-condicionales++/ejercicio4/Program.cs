using System;

namespace ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            /*4. Hacer un programa para ingresar tres números y emitir un cartel aclaratorio si la suma de 
            los dos primeros es mayor al producto del segundo con el tercero. */

            int num1, num2, num3;
            string opcion = "";

            Console.WriteLine("Ingrese 3 números: ");
            num1 = int.Parse(Console.ReadLine());
            num2 = int.Parse(Console.ReadLine());
            num3 = int.Parse(Console.ReadLine());

            if((num1 + num2) > (num2 * num3))
                Console.WriteLine("La suma de los dos primeros nros es mayor al producto del segundo con el tercero");
            else
                Console.WriteLine("La suma de los dos primeros nros es menor al producto del segundo con el tercero");

             
            
        }
    }
}
