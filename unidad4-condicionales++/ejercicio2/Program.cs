using System;

namespace ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*  Un importante negocio de desinfectante líquido realiza descuentos dependiendo 
            de la cantidad de litros vendidos según la siguiente escala:
            -Si vende menos de 100 litros, no hay descuento.
            -Si vende entre 101 y 300 litros, el descuento es del 10%.
            -Si vende entre 301 y 500 litros, el descuento es del 15%.
            -Finalmente, si la venta es de más de 500 litros, el descuento es del 25%.
            Hacer un programa que solicite el ingreso del importe total de la venta y la cantidad de litros 
            vendidos y calcule y emita el importe con el descuento  aplicado..*/

            //Declaramos variables
            float importetotal, litros, importeFinal;
            string descuento = "";

            //Pedimos los datos al usuario
            Console.WriteLine("Ingrese el importe del total de venta:");
            importetotal = float.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la cantidad de litros vendidos:");
            litros = float.Parse(Console.ReadLine());

            //Condiciones
            if(litros >= 500F)
                descuento = "25";
            else if (litros >= 301F && litros < 500F )
                descuento = "15";
            else if(litros >= 101F && litros <= 300F)
                descuento = "10";
            else
                descuento = "0";    
                

            switch (descuento)
            {
                case "25":
                    importeFinal = importetotal * 0.75F;
                    Console.WriteLine("Su compra supera los 500 litros, entonces 25%OFF, el precio final es: " + importeFinal);
                    break;
                case "15":
                    importeFinal = importetotal * 0.85F;
                    Console.WriteLine("Su compra está entre 301 y 500 litros, entonces 15%OFF, el precio final es: " + importeFinal);
                    break;
                case "10":
                    importeFinal = importetotal * 0.90F;
                    Console.WriteLine("Su compra entá entre 101 y 300 litros , entonces 10%OFF, el precio final es: " + importeFinal);
                    break;
                case "0":
                    Console.WriteLine("Su compra no supera los 100 litros, no tienes desc., el precio final es: " + importetotal);  
                    break;      
                default:
                    Console.WriteLine("Ingrese un valor correcto");
                    break;
            }    
        }
    }
}
