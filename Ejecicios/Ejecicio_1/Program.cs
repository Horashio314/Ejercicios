namespace Ejecicio_1
{
    class Program
    {
        private static string ValidarNumero(int numero)
        {
            if (numero % 3 == 0 & numero % 5 == 0)
                return "FizzBuzz";
            if (numero % 3 == 0)
                return "Fizz";
            if (numero % 5 == 0)
                return "Buzz";
            return numero.ToString();
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