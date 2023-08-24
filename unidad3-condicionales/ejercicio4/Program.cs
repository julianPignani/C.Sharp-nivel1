using System;

namespace ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            /*4. Hacer un programa para ingresar cuatro números distintos y luego mostrar
             por pantalla el menor de ellos. */

             //Declaramos variables
             int num1, num2, num3, num4, menor;

             //pedimos al usuario que ingrese los datos
            Console.WriteLine("Ingrese 4 números para obtener el menor de ellos: ");
            num1 = int.Parse(Console.ReadLine());
            num2 = int.Parse(Console.ReadLine());
            num3 = int.Parse(Console.ReadLine());
            num4 = int.Parse(Console.ReadLine());

            //Condicion

            if(num1 < num2 )
                menor = num1;
            else 
                menor = num2;

            if(num3 < menor )
                menor = num3;
            
            if(num4 < menor)
                menor = num4;
            
            Console.WriteLine("El número menor es: " + menor);

        }
    }
}
