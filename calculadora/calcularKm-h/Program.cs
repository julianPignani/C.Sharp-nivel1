using System;

namespace calcularKm_h
{
    class Program
    {
        static void Main(string[] args)
        {
          /* 3. Hacer un programa que permita ingresar los kilómetros existentes entre dos ciudades
           y la velocidad promedio de un vehículo. Calcular y emitir por pantalla el tiempo aproximado
           que demandará llegar de un punto a otro teniendo en cuenta los datos ingresados. */

           //variables
           float kilometros, velocidad, tiempoEstimado;

           //pedimos valores
           Console.WriteLine("Ingrese la distancia en Kilometros que hay entre Buenos Aires y Córdoba: ");
           kilometros = float.Parse(Console.ReadLine());

           Console.WriteLine("Ingrese la velocidad promedio del vehiculo: ");
           velocidad = float.Parse(Console.ReadLine());

           //Calculamos el tiempo estimado que le pondria el auto en llegar
           tiempoEstimado = kilometros / velocidad;

           //mostramos resultados
           Console.WriteLine("El vehiculo tardaria aproximadamente " + tiempoEstimado + " en llegar.");
        }
    }
}
