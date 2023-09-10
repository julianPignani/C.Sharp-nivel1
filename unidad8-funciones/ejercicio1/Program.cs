using System;

namespace ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*1. Hacer una función llamada “producto” que reciba dos números enteros y que devuelva el 
            producto de ambos. Luego hacer un programa que pida el precio de un artículo y la cantidad
             vendida y muestre por pantalla el monto total a pagar. Usar la función. */

             int num1 = 10, num2 = 15 ,resultado;
             int precio = 0, cantidadVendida = 0, precioFinal;

             
             resultado = calcularProducto(num1, num2);
            
             pedirDatos(ref precio, ref cantidadVendida);
             precioFinal = calcularProducto(precio, cantidadVendida);

             Console.WriteLine("El producto de los dos números ingresados es: " + resultado);
             Console.WriteLine("El precio final a pagar es: " + precioFinal);
        }

        static int calcularProducto(int n1, int n2){
            int producto = n1 * n2;
            return producto;

        }

        static void pedirDatos(ref int n1, ref int n2){
            Console.WriteLine("Ingrese el precio del producto: ");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la cantidad de productos comprados: ");
            n2 = int.Parse(Console.ReadLine());
        }
    }
}
