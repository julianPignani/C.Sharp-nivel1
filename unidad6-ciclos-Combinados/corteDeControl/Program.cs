using System;

namespace corteDeControl
{
    class Program
    {
        static void Main(string[] args)
        {
            //Corte de control -> para manejar lotes de datos agrupados.
            //ejemplo, cargar legajo, edad , sueldo , codigo equipo

            int legajo, edad, codigoEquipo;
            float sueldo;
            int equipoActual;

            Console.WriteLine("Ingrese el legajo: ");
            legajo = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la edad: ");
            edad = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el sueldo: ");
            sueldo = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el código de equipo: ");
            codigoEquipo = int.Parse(Console.ReadLine());

            //mientras el sueldo sea mayor a 0
            while (sueldo > 0)
            {   
                //Asignación clave para que el corte de control separe los lotes
                equipoActual = codigoEquipo;

                while (codigoEquipo == equipoActual)
                {

                     //Acá procesamos...   


                    Console.WriteLine("Ingrese el legajo: ");
                    legajo = int.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese la edad: ");
                    edad = int.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese el sueldo: ");
                    sueldo = float.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese el código de equipo: ");
                    codigoEquipo = int.Parse(Console.ReadLine());

                    //acá podemos motras datos
                }
                //acá podemos motras datos
            }
            //acá podemos motras datos
        }
    }
}
