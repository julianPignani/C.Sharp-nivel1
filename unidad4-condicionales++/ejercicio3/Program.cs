using System;

namespace ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 3. Una importante marca de computadoras permite elegir cierta configuración del equipo 
            a comprar. Para ello existe la siguiente escala de precios:
                        i5 (1)	    i7 (2)	    i9 (3)
            -8 RAM (1)	USD 800	    USD 900	    USD 1200
            -16 RAM (2)	USD 900	    USD 1000	USD 1400
            -32 RAM (3)	USD 1000	USD 1400	USD 2000
            Además, el equipo viene con un disco que permite almacenar 500 GB de información y que se puede
             ampliar a 1 TB si así lo desea, lo cual tiene un costo  adicional de USD 300. Hacer un programa
              que solicite la opción de procesador, la opción de memoria  RAM, y si extiende el disco o no 
              (ingresa 1 para extender y 0 para no extender) y calcule y emita por pantalla el monto de la 
              máquina seleccionada. */

            //declaramos las variables
            int opcionMemoria, opcionDisco, precio = 0, opcionProcesador;
             

            //pedimos los datos al usuario
            Console.WriteLine("Ingrése una opción según el procesador que desea comprar: " + 
            "\nOpcion 1 si deseas un procesador I5. " + 
            "\nOpcion 2 si deseas un precesador I7. " +
            "\nOpcion 3 si deseas un procesador I9. ");
            opcionProcesador = int.Parse(Console.ReadLine());

            Console.WriteLine("Con que memoria deseas comprar tu procesador: " +
            "\nOpcion 1 si deseas una memoria de 8 RAM. " + 
            "\nOpcion 2 si deseas una memoria de 16 RAM. " +
            "\nOpcion 3 si deseas una memoria de 32 Ram. ");
            opcionMemoria = int.Parse(Console.ReadLine());


            Console.WriteLine("Deseas extender el disco por un precio de 300 usd?: " + 
            "\nOpcion 1 si deseas extenderlo." + 
            "\nOpcion 0 si no deseas extenderlo.");
            opcionDisco = int.Parse(Console.ReadLine());

            switch(opcionProcesador)
            {
                case 1: 
                    switch(opcionMemoria){
                        case 1: 
                            precio = 800;
                            Console.WriteLine("El procesador I5 + 8 RAM cuesta " + precio + " USD." );
                            break;
                        case 2:
                            precio = 900;
                            Console.WriteLine("El procesador I5 + 16 RAM cuesta " + precio + " USD." );
                            break;
                        case 3:
                            precio = 1000;
                            Console.WriteLine("El procesador I5 + 32 RAM cuesta " + precio + " USD." );   
                            break; 
                    }
                    break;
                case 2:
                    switch(opcionMemoria){
                        case 1: 
                            precio = 900;
                            Console.WriteLine("El procesador I7 + 8 RAM cuesta " + precio + " USD." );
                            break;
                        case 2:
                            precio = 1000;
                            Console.WriteLine("El procesador I7 + 16 RAM cuesta " + precio + " USD." );
                            break;
                        case 3:
                            precio = 1400;
                            Console.WriteLine("El procesador I7 + 32 RAM cuesta " + precio + " USD." );   
                            break; 
                    }
                    break;
                case 3:
                    switch(opcionMemoria){
                        case 1: 
                            precio = 1200;
                            Console.WriteLine("El procesador I9 + 8 RAM cuesta " + precio + " USD." );
                            break;
                        case 2:
                            precio = 1400;
                            Console.WriteLine("El procesador I9 + 16 RAM cuesta " + precio + " USD." );
                            break;
                        case 3:
                            precio = 2000;
                            Console.WriteLine("El procesador I9 + 32 RAM cuesta " + precio + " USD." );   
                            break; 
                    }
                    break;
                default:
                    Console.WriteLine("Ingrese un número valido");    
                    break;
            }

            if(opcionDisco == 1){
                precio = precio + 300;
                Console.WriteLine("El precio final de la compu con la extención de disco es: " + precio+ " usd.");
            }
            else if(opcionDisco == 0 ){
                precio = precio;
                Console.WriteLine("El precio final de la compu con la extención de disco es: " + precio + " usd.");
            }
        }
    }
}
