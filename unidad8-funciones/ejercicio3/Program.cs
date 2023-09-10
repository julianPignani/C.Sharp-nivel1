using System;

namespace ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*3. Hacer una función llamada “primo” que reciba un número entero y devuelva 1 si el número
             es primo o cero si no lo es. Hacer un programa para ingresar números. El lote corta cuando 
             se ingresa un número cero. Informar el promedio teniendo en cuenta sólo los números primos.*/

             int num = 7, numeros;
             int numPrimo = primo(num);
             double promedio;
             Console.WriteLine("El nro ingresado es primo?: " + numPrimo);

             Console.WriteLine("Ingrese nros y 0 para finalizar: ");
             numeros = int.Parse(Console.ReadLine());
            
             int acumulador = 0, contador = 0;
             while (numeros != 0)
             {
                int esPrimo = primo(numeros);
                if(esPrimo == 1){
                    acumulador += numeros;
                    contador++;
                }

                 Console.WriteLine("Ingrese nros y 0 para finalizar: ");
                 numeros = int.Parse(Console.ReadLine());
             }
             promedio = (double) acumulador / contador;
             Console.WriteLine("El promedio de los numeros primos es: " + promedio);
             


        }
        static int primo(int n1){
            int esPrimo = 1;

            if(n1 <= 1){
                esPrimo = 0;
            }else{
                for (int i = 2; i <= n1 / 2; i++)
                {
                    if(n1 % 2 == 0){
                        esPrimo = 0;
                        break;
                    }
                }
            }   
            return esPrimo; 
        }
    }
}
