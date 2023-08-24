using System;

namespace ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 3. Una casa de video juegos otorga un descuento dependiendo del importe de la compra realizada 
            según los siguientes valores:
            Si el importe es menor a ARS 1000, no hay descuento.
            Si el importe es ARS 1000 o más pero menor a ARS 5000, aplica un descuento del 10%.
            Si el importe es ARS 5000 o más, aplica un descuento del 18%.
            Hacer un programa para ingresar un importe de venta y luego muestre por pantalla el importe final 
            con el descuento que corresponda.*/

            //Declaramos la variable
            float importeVenta, importeFinal;

            //Pedimos el importe de venta
            Console.WriteLine("Ingrese el importe de venta: ");
            importeVenta = float.Parse(Console.ReadLine());

            //Condición
            if(importeVenta >= 5000){
                importeFinal = (float) importeVenta * 0.82F; //0.82 porq es lo que me falta para 100% (18%)
                Console.WriteLine("El precio final de la compra con el descuento del 18% es: " + importeFinal.ToString("N2"));
            }else if(importeVenta >= 1000 && importeVenta < 5000){
                importeFinal = (float) importeVenta * 0.90F; //0.90 porq es lo que falta para 100% (10%)
                Console.WriteLine("El precio final de la compra con el descuento de 10% es: " + importeFinal.ToString("N2"));
            }else{
                Console.WriteLine("El importe de la compra no supero los $1000,por lo tanto no hay descuento");
                Console.WriteLine("El total  de la compra  seria: " + importeVenta.ToString("N2"));
            }
                
        }
    }
}
