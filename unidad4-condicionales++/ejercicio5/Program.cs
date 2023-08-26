using System;

namespace ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            /*5. Hacer un programa para ingresar 4 números. Luego analizar e informar por pantalla si 
            los mismos se encuentran ordenados de forma decreciente . */

            int num1, num2, num3, num4;

            Console.WriteLine("Ingrese 4 números: ");
            num1 = int.Parse(Console.ReadLine());
            num2 = int.Parse(Console.ReadLine());
            num3 = int.Parse(Console.ReadLine());
            num4 = int.Parse(Console.ReadLine());

            if(num1 > num2 && num2 > num3 && num3 > num4)
                Console.WriteLine("Los números estan ordenados de forma decreciente.");
            else
                Console.WriteLine("Los números no estan ordenados");    

        }
    }
}
