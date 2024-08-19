/*
 * Escribe un programa que imprima los 50 primeros números de la sucesión
 * de Fibonacci empezando en 0.
 * - La serie Fibonacci se compone por una sucesión de números en
 *   la que el siguiente siempre es la suma de los dos anteriores.
 *   0, 1, 1, 2, 3, 5, 8, 13...
 */

 namespace Ejercicio_3
 {
    class Program{
        static void Main(){
            double fibo_ant = 0;
            double fibo = 1;
            double fibo_aux = 1;

            Console.WriteLine(fibo_ant);

            for (int i = 1; i<=49; i++)
            {
                Console.WriteLine(fibo);
                fibo_aux = fibo;
                fibo = fibo_ant + fibo;
                fibo_ant = fibo_aux;
            }
        }
    }
 }