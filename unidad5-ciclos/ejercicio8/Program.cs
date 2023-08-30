using System;

namespace ejercicio8
{
    class Program
    {
        static void Main(string[] args)
        {
            /*3. Hacer un programa que solicite 20 edades y luego calcule el promedio de edad de 
            aquellas personas mayores a 18 años. */

            int edad, contador = 0 ,acumulador = 0, numero = 0;
            float promedio;

            while (numero < 20)
            {
                Console.WriteLine("Ingrese un número: ");
                edad = int.Parse(Console.ReadLine());

                if(edad >= 18){
                    contador++;
                    acumulador += edad;
                }

                numero++;
            }
            promedio = (float) acumulador / contador;
            Console.WriteLine("El promedio de las edades mayores a 18 años es: " + promedio.ToString("N2"));


        }
    }
}
