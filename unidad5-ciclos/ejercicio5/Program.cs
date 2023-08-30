using System;

namespace ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
           /*5. Hacer un programa que solicite 20 números y luego emitir por pantalla el máximo de los
            números pares y el mínimo de los números impares. */ 

            int numero, max = 0, min = 0;
            int conPar = 0, conImpar = 0;    

            Console.WriteLine("El programa te solicitará 20 nros para determinar el maximo y el minimo.");

            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine("Ingrese un número: ");
                numero = int.Parse(Console.ReadLine());

                if(numero % 2 == 0){ // Si es par, entra el numero.
                    conPar++; //y contamos
                    if(conPar == 1){ //Si es == 1, significa que es el primer par
                        max = numero;//entonces los lo inicializamos
                    } else if(numero > max){
                        max = numero;    
                    }
                }else{
                    conImpar++;
                    if(conImpar == 1){
                        min = numero;
                    }else if(numero < min){
                        min = numero;
                    }
                }
                       
                
            }

            Console.WriteLine("El número máximo par es : " + max + " y el número mínimo impar es: " + min);
        }
    }
}
