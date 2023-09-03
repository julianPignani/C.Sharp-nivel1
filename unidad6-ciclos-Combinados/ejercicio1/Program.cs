using System;

namespace ejemplos
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 1. Hacer un programa para ingresar 10 números. El mismo debe analizar y mostrar por 
            pantalla cuántos de esos números son primos.*/

            int numero, contador = 0;
            bool esPrimo;

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Ingrese un número: ");
                numero = int.Parse(Console.ReadLine());

                esPrimo = true;

                if (numero <= 1 )
                    esPrimo = false;
                else{
                    for (int j = 2; j <= numero / 2 ; j++) {
                        if (numero % j == 0)
                        {
                            esPrimo = false;
                            break;
                        }
                    }
                }
                if(esPrimo)
                    contador++;
                
            }

            Console.WriteLine("La cantidad de números primos ingresados son: " + contador);
        }
    }
}
