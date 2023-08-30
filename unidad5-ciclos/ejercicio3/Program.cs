using System;

namespace ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*3. Hacer un programa que solicite 20 edades y luego calcule el promedio de edad de 
            aquellas personas mayores a 18 años. */

            int edad, contador = 0, acumulador = 0;
            float promedio;

            Console.WriteLine("El siguiente programa le solicitará que ingrese 20 edades. ");

            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine("Ingrese una edad: ");
                edad = int.Parse(Console.ReadLine());

                if(edad >= 18){
                    acumulador += edad;
                    contador++;
                }
            }
            promedio = (float) acumulador / contador;

            Console.WriteLine("El promedio de edades mayores a 18 años es: " + promedio.ToString("N2"));
        }
    }
}
