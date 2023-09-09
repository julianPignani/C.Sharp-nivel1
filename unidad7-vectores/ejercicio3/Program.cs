﻿using System;

namespace ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 3. Hacer un programa que solicite una cadena de caracteres y dos caracteres sueltos
             (tres ingresos). El programa deberá generar una cadena donde todas las ocurrencias del
              primer carácter dado hayan sido reemplazadas por el segundo. Mostrar el resultado en pantalla. 
              Ejemplo:
                CADENA FUENTE: “La mar estaba serena"
                CARÁCTER 1: ‘a’ CARÁCTER 2: ‘i’
                CADENA RESULTADO: “Li mir estibi sereni"*/

                char primerLetra, segundaLetra;
                string frase = "";

                Console.WriteLine("Ingrese un caracter y luego otro para reemplazarlo...");
                primerLetra = char.Parse(Console.ReadLine());
                segundaLetra = char.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese una frase..");
                frase = Console.ReadLine();

                string nuevaFrase = frase.Replace(primerLetra , segundaLetra);

                Console.WriteLine("nueva frase: " + nuevaFrase);
        }
    }
}
