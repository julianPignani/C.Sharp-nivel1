using System;

namespace ejercicio7
{
    class Program
    {
        static void Main(string[] args)
        {
             /*2. Hacer un programa que solicite el ingreso de 10 números y que muestre el mayor de ellos por
             pantalla. Solo se debe emitir UN valor por pantalla.*/

             int contador = 0, numero, mayor = 0;
             while (contador < 10)
             {
                Console.WriteLine("Ingrese un número: ");
                numero = int.Parse(Console.ReadLine());

                if(numero > mayor){
                    mayor = numero;
                }
                contador++;    
             }
             Console.WriteLine("El número mayor es: " + mayor);
        }
    }
}
