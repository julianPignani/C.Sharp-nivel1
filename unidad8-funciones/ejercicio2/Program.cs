using System;

namespace ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 2. Hacer una función llamada “par” que reciba un número entero y devuelva 1 si es par o 
            cero si no lo es. Hacer un programa para ingresar 20 números y mostrar por pantalla cuántos 
            son pares.*/

            int numero = 6, numeros, contador = 0;
            int nroPar = esPar(numero);
            Console.WriteLine("El nro es par?: " + nroPar);


            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine("Ingrese un nro: ");
                numeros = int.Parse(Console.ReadLine());
                int numPar = esPar( numeros);
                if (numPar == 1)
                {
                    contador++;
                }
            }

            Console.WriteLine("De los 20 nros ingresados, " + contador  + " son pares.");


        }
        static int esPar( int n1){
            int par = 0;
            if (n1 % 2 == 0)
                par = 1;
            else
                par = 0;
            return par;
        }
    }
}
