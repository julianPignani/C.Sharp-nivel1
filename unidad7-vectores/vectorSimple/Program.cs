using System;

namespace vectorSimple
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, acumulador = 0;
            double promedio;
            int[] numeros = new  int[10];

            for (int i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine("Ingrese la nota:..");
                num = int.Parse(Console.ReadLine());
                numeros[i] = num; 
                acumulador += numeros[i];
            }

            promedio = (double) acumulador / numeros.Length;

            Console.WriteLine("El promedio de las notas es: " + promedio);
        }
    }
}
