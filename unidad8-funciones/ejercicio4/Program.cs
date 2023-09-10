using System;

namespace ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            /*4. Hacer una función de tipo void (porque no va a devolver nada) llamada “positivoNegativoCero”
             que reciba un número por valor y una variable por referencia. Que analice el número y escriba
              variable recibida por referencia con:

                a. 1 si el número es positivo.
                b. -1 si el número es negativo.
                c. 0 si el número es cero. */

             int num1, estado = 0;
             Console.WriteLine("Ingrese un nro: ");
             num1 = int.Parse(Console.ReadLine());

             positivoNegativoCero(num1, ref estado);

             Console.WriteLine("El valor del nro ingresado " + num1 + " tiene un estado de: " + estado);   

        }
        static void positivoNegativoCero(int num1, ref int estado){
            if(num1 > 0)
                estado = 1;
            else if(num1 == 0)
                estado = 0;
            else
                estado = -1;        
        }
    }
}
