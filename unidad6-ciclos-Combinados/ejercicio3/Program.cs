using System;
using System.Diagnostics.Contracts;

namespace ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*3. Hacer un programa para recibir listas de números positivos que están separadas entre sí
             por un cero. El fin de la carga se notifica con un número negativo. Luego mostrar cuántos números
              tiene cada lista. */
            int numero, contador, numGrupo = 0;
            

            do
            {
                contador = 0;
                numGrupo++;
                Console.WriteLine("Ingrese un número");
                numero = int.Parse(Console.ReadLine());

                while (numero > 0)
                {
                    contador++;
                    Console.WriteLine("Ingrese un número");
                    numero = int.Parse(Console.ReadLine());
                }
                Console.WriteLine("El grupo " + numGrupo + " tiene " + contador + " números.");
            } while (numero >= 0);

        }
    }
}
