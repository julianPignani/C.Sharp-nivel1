using System;

namespace ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            /*4. Hacer un programa que solicite UN número y luego calcule y emita un cartel aclaratorio si 
            el mismo es primo o no es primo.  Nota: un numero es primo cuando es divisible únicamente por 1
             y por sí mismo. */

            Console.WriteLine("Ingrese un número: ");
            int numero = Convert.ToInt32(Console.ReadLine());

            bool esPrimo = true;

            if(numero <= 1){
                esPrimo = false;
            }else{
                for (int i = 2; i <= numero / 2; i++)
                {
                    if(numero % i == 0){
                        esPrimo = false;
                        break;
                    }
                }
            }
            if(esPrimo)
                Console.WriteLine("El número " + numero + " es primo.");
            else
                Console.WriteLine("El número " + numero + " no es primo.");    
        }   
    }
}
