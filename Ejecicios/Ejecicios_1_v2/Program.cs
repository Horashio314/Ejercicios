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