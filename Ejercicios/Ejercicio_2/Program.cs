/// <summary>
/// Escribe una función que reciba dos palabras (String) y retorne
/// verdadero o falso (Bool) según sean o no anagramas.
/// - Un Anagrama consiste en formar una palabra reordenando TODAS
///   las letras de otra palabra inicial.
/// - NO hace falta comprobar que ambas palabras existan.
/// - Dos palabras exactamente iguales no son anagrama.
/// </summary>

namespace Ejercicio_2{
    class Program{

        private static bool SonAnagramas(string palabra1, string palabra2){
            if (palabra1 == palabra2)
                return false;

            if (palabra1.Length != palabra2.Length)
                return false;

            char[] letras1 = palabra1.ToCharArray();
            char[] letras2 = palabra2.ToCharArray();

            Array.Sort(letras1);
            Array.Sort(letras2);

            for (int i = 0; i < letras1.Length; i++){
                if (letras1[i] != letras2[i])
                    return false;
            }

            return true;
        }


        static void Main(string[] args){
            // Recibo los valores
            Console.WriteLine("Ingrese la primera palabra: ");
            string palabra1 = Console.ReadLine() == null? "": "";

            Console.WriteLine("Ingrese la segunda palabra: ");
            string palabra2 = Console.ReadLine() == null? "": "";;

            if (palabra1 == null || palabra2 == null){
                Console.WriteLine("No se ingresaron palabras.");
                return;
            }

            if (SonAnagramas(palabra1, palabra2) == true)
                Console.WriteLine("Las palabras con anagramas");
            else
                Console.WriteLine("Las palabras no son anagramas");
        }
    }
}