using System;

namespace calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. Hacer un programa para solicitar dos números y luego calcule y emita la suma en pantalla.
            //paso 0: declarar las variables.
            int n1, n2, resultado;
            
            //paso 1:  pedir valores.
            Console.WriteLine("Ingrese un número: ");
            n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese otro número: ");
            n2 = int.Parse(Console.ReadLine());

            //paso 2: realizar calculos. (+ , - , * , /)
            resultado = (n1 + n2 );

            //paso 3: emitir resultados.
            Console.WriteLine("El resultado de la suma es: " + resultado);
        }
    }
}
