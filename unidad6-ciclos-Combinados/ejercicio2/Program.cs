using System;

namespace ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*2. Se dispone de una lista de 5 listas de números enteros separados entre ellos por ceros.
             Se pide determinar e informar:
             A)El número de grupo con mayor porcentajeImpares de números impares respecto al total de números que
             forman el grupo.
             B)Informar cuántos grupos están formados por todos números ordenados de mayor a menor.*/

             int numero, contador , impares , grupoImparMaximo = 0, minimo, contadorOrdenados = 0;
             double porcentajeImpares, porcentajeMaximo = -1;
             bool banderaOrdenados;
            for (int i = 0; i < 5; i++)
            {
                contador = 0;
                impares = 0;
                banderaOrdenados = true;
                Console.WriteLine("Ingrese el número de lista: ");
                numero = int.Parse(Console.ReadLine());
                minimo = numero;
                while (numero != 0)
                {
                    //punto A)
                    contador++;
                    if(numero % 2 != 0)
                        impares++;

                    //Punto B) 
                    if(numero <= minimo)
                        minimo = numero;  
                    else
                        banderaOrdenados = false;     

                    Console.WriteLine("Ingrese un  número a la lista: ");
                    numero = int.Parse(Console.ReadLine());
                } 
                //Calculamos el porcentaje de impares maximo
                porcentajeImpares = (double) (impares * 100) / contador;
                if(porcentajeImpares > porcentajeMaximo){
                    porcentajeMaximo = porcentajeImpares;
                    grupoImparMaximo = i + 1;
                }

                //Punto B)
                if(banderaOrdenados == true)
                    contadorOrdenados++;

            }
            Console.WriteLine("El grupo con mayor porcentaje de impares es: " + grupoImparMaximo);
            Console.WriteLine("La cantidad de grupos con nros ordenados es:  " + contadorOrdenados);
        }
    }
}
