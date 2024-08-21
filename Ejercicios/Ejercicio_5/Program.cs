/*
 * Crea una única función (importante que sólo sea una) que sea capaz
 * de calcular y retornar el área de un polígono.
 * - La función recibirá por parámetro sólo UN polígono a la vez.
 * - Los polígonos soportados serán Triángulo, Cuadrado y Rectángulo.
 * - Imprime el cálculo del área de un polígono de cada tipo.
 */

 namespace Ejercicio_5
 {
    class Ejercicio_5
    {
        static double AreaPoligono(string tipo, double lado1, double lado2 = 0){
            double area = 0;
            switch(tipo){
                case "Triangulo":
                    area = (lado1 * lado2) / 2;
                    break;
                case "Cuadrado":
                    area = lado1 * lado1;
                    break;
                case "Rectangulo":
                    area = lado1 * lado2;
                    break;
            }

            return area;
        }

        static void Main(){
            System.Console.WriteLine("Area de un Triangulo: " + AreaPoligono("Triangulo", 5, 3));
            System.Console.WriteLine("Area de un Cuadrado: " + AreaPoligono("Cuadrado", 5));
            System.Console.WriteLine("Area de un Rectangulo: " + AreaPoligono("Rectangulo", 5, 3));
        }
    }
 }