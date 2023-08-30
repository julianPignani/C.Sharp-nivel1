using System;

namespace ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*2. Hacer un programa que solicite el ingreso de 10 números y que muestre el mayor de ellos por
             pantalla. Solo se debe emitir UN valor por pantalla.*/

            int n, mayor = 0;

            Console.WriteLine("Ingrese 10 números.");

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Ingrese un número: ");
                n = int.Parse(Console.ReadLine());

                if(n > mayor)
                    mayor = n;
            }
            
            Console.WriteLine("El número mayor ingresado es: " + mayor);
        }
    }
}
