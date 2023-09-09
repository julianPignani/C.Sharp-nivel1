using System;

namespace ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
          /* 2. Hacer un programa que solicite 10  números enteros y los guarde en un vector. 
          Luego recorrer ese vector para calcular el promedio. Mostrar por pantalla los valores que son 
          mayores al promedio.*/  

          int[] numeros = new int[10];
          double promedio;
          int num, acumulador = 0;

          for (int i = 0; i < 10; i++)
          {
            Console.WriteLine("Ingrese un número: ");
            num = int.Parse(Console.ReadLine());
            numeros[i] = num;
          }
          for (int i = 0; i < numeros.Length; i++)
          {
            acumulador += numeros[i];
          }

          promedio = (double) acumulador / 10;
          

         for (int i = 0; i < numeros.Length; i++)
         {
            if(numeros[i] > promedio){
                Console.WriteLine("El número " + numeros[i]  + " es mayor al promedio");
            }
                
         }   
        }
    }
}
