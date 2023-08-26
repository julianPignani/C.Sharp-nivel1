using System;

namespace ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*1. Hacer un programa que solicite el ingreso de dos números y luego calcular:
            La resta si el primero es mayor que el segundo.
            La suma si son iguales.
            El producto si el primero es menor.
            Se deberá emitir un cartel por pantalla con el resultado correspondiente. */

            //declaramos las dos variables
            int num1, num2, resultado;
            string operacion = "";

            //Pedimos los datos
            Console.WriteLine("Ingrese dos números: ");
            num1 = int.Parse(Console.ReadLine());
            num2 = int.Parse(Console.ReadLine());

            //condiciones
            if(num1 > num2)
                operacion = "resta";
            else if(num1 < num2)
                operacion = "producto";
            else 
                operacion = "sumar";    


            switch (operacion)
            {
                case "resta":
                    resultado = num1 - num2;
                    Console.WriteLine("El resultado de la resta es: " + resultado);
                    break;
                case "producto":
                    resultado = num1 * num2;
                    Console.WriteLine("El resultado de la multiplicación es: " + resultado);
                    break;
                case "sumar":
                    resultado = num1 + num2;
                    Console.WriteLine("El resultado de la suma es: " + resultado);
                    break;        
                default:
                        Console.WriteLine("Ingrese un valor correcto.");
                        break;
            }        
        }
    }
}
