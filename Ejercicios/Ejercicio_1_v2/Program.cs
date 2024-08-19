﻿/*
 * Escribe un programa que muestre por consola (con un print) los
 * números de 1 a 100 (ambos incluidos y con un salto de línea entre
 * cada impresión), sustituyendo los siguientes:
 * - Múltiplos de 3 por la palabra "fizz".
 * - Múltiplos de 5 por la palabra "buzz".
 * - Múltiplos de 3 y de 5 a la vez por la palabra "fizzbuzz".
 */

namespace Ejecicio_1
{
    class Program
    {
        private static string ValidarNumero(int numero)
        {
            string num = "";

            if (numero % 3 == 0)
                num += "Fizz";
            if (numero % 5 == 0)
                num += "Buzz";
            if (num == "")
                num = numero.ToString();

            return num;
        }

        static void Main()
        {
            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine(ValidarNumero(i));
            }
        }
    }
}