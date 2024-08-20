/*
 * Escribe un programa que se encargue de comprobar si un número es o no primo.
 * Hecho esto, imprime los números primos entre 1 y 100.
 */

using System.Threading.Tasks.Dataflow;

namespace Ejercicio_4 
 {
    class Ejercicio_4
    {
        private static bool Primo(int numero){
            if (numero < 2)
                return false;

            for (int i = 2; i != numero; i++)
                if (numero % i == 0)
                    return false;
            
            return true;
        }
        static void Main(){
            for (int i = 1; i <= 100; i++)
                if (Primo(i) == true)
                    Console.WriteLine("El numero " + i + " es primo");
                //Console.WriteLine(Primo(i) == true ? "El numero " + i + " es primo" : null);

        }
    }
 }