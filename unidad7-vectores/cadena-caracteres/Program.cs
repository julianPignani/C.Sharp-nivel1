using System;

namespace cadena_caracteres
{
    class Program
    {
        static void Main(string[] args)
        {
            //Cadena de caracteres  a bajo  nivel.
            char[] nombre = new char[10];
            char letra;

            Console.WriteLine("Ingrese su nombre letra por letra..(termina el programa con un punto)");
            letra = char.Parse(Console.ReadLine());

            int indice = 0;
            while (letra != '.' && indice < 10)
            {
                nombre[indice] = letra;
                letra = char.Parse(Console.ReadLine());
                indice++;
            }
            nombre[indice] = '\0';    

            Console.Write("Hola ");
            indice = 0;
            while (nombre[indice] != '\0')
            {
                Console.Write(nombre[indice]);
                indice++;
            }
        }
    }
}
