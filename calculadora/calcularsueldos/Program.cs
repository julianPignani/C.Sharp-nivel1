using System;

namespace calcularsueldos
{
    class Program
    {
        static void Main(string[] args)
        {
            /*4. Una casa de computación paga a sus empleados un sueldo fijo de ARS15000 más una comisión del
             5% sobre el total facturado por cada empleado. Hacer un programa para ingresar el total facturado
            por un empleado y que luego calcule y emita por pantalla el sueldo total a cobrar por el mismo.*/

            //Variables y constantes
            const float SueldoFijo = 15000F, Comision = 0.05F;
            float sueldoTotal, totalFacturado;

            //pedimos el total facturado al empleado
            Console.WriteLine("Ingrese el total facturado: ");
            totalFacturado = float.Parse(Console.ReadLine());

            //Realizamos el calculo
            sueldoTotal = (totalFacturado * Comision) + SueldoFijo;

            //mostramos los datos
            Console.WriteLine("El sueldo total del empleado es: " + sueldoTotal);


        }
    }
}
