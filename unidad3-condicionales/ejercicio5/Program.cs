using System;

namespace ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            /*5. Hacer un programa para ingresar cuatro números y luego mostrar por pantalla cuáles 
            son mayores a 100.*/

            //Variables
            int num1, num2, num3, num4;

            //Pedimos al usuario el numero
            Console.WriteLine("Ingrese cuatro números: ");
            num1 = int.Parse(Console.ReadLine());
            num2 = int.Parse(Console.ReadLine());
            num3 = int.Parse(Console.ReadLine());
            num4 = int.Parse(Console.ReadLine());

            //Condición
            if(num1 > 100){
                Console.WriteLine("Mostramos el número " + num1 + " por que es mayo a 100.");
            }   
            if(num2 > 100){
                Console.WriteLine("Mostramos el número " + num2 + " por que es mayo a 100.");
            }    
            if(num3 > 100){
                Console.WriteLine("Mostramos el número " + num3 + " por que es mayo a 100.");
            }
            if(num4 > 100){
                Console.WriteLine("Mostramos el número " + num4 + " por que es mayo a 100.");
            }            
        }
    }
}
