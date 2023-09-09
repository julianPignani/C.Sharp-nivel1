using System;

namespace ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            /*4. Una empresa comercializa 15 tipos de artículos y por cada venta realizada genera 
            un registro con los siguientes datos:
                - Número de Artículo (1 a 15)
                - Cantidad Vendida  */
            /* Puede haber varios registros para el mismo artículo y el último se indica con número de 
            artículo igual a 0. Se pide determinar e informar:
                a) El número de artículo que más se vendió en total.
                b) Los números de artículos que no registraron ventas.
                c) Cuantas unidades se vendieron del número de artículo 10.*/   

            int nroArticulo, cantidad;
            int[] totalCantidadVendida = new int[15];

            for (int i = 0; i < totalCantidadVendida.Length; i++)
            {
                totalCantidadVendida[i] = 0;
            }

            Console.WriteLine("Ingrese el nro de artículo: ");
            nroArticulo = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la cantidad de venta: ");
            cantidad = int.Parse(Console.ReadLine());

            while (nroArticulo != 0)
            {
                totalCantidadVendida[nroArticulo - 1] += cantidad;
            
                Console.WriteLine("Ingrese el nro de artículo: ");
                nroArticulo = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese la cantidad de venta: ");
                cantidad = int.Parse(Console.ReadLine());
            }

            //Punto A)
            int maxCantidad = totalCantidadVendida[0];
            int nroMaximo = 1;

            for (int i = 0; i < length; i++)
            {
                if(totalCantidadVendida[i] > maxCantidad){
                    maxCantidad = totalCantidadVendida[i];
                    nroArticulo = i + 1;
                }
            }
            Console.WriteLine("El producto más vendido es el: " + nroArticulo  + " con una cantidad de " + maxCantidad);

            //Punto B)
            for (int i = 0; i < length; i++)
            {
                if(totalCantidadVendida[i] == 0){
                    Console.WriteLine("El producto " + (x + 1) + " no tuvo ventas.");
                }
            }

            //Punto C)
            Console.WriteLine("La cantidad vendida del artículo 10 es: " + totalCantidadVendida[9]);
        }
    }
}
