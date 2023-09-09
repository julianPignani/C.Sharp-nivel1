using System;

namespace ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 1. Hacer un programa que solicite 10 números enteros y los guarde en un vector.
             Luego recorrer los elementos y determinar e informar cuál es el valor máximo y su posición 
             dentro del vector.*/

             int[] numeros = new int[10];
             int num, mayor = 0, ubicacion = 0;
             


            for (int i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine("Ingrese un numero: ");
                num = int.Parse(Console.ReadLine());
                numeros[i] = num;
            }
             for (int i = 0; i < numeros.Length; i++)
             {
                if(numeros[i] > mayor){
                     mayor = numeros[i]; 
                    ubicacion = i;
                }
             }

             Console.WriteLine("EL mayor es " + mayor + " y esta en la posición " + ubicacion + " del vector.");

        }
    }
}
