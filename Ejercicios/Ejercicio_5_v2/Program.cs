/*
 * Crea una única función (importante que sólo sea una) que sea capaz
 * de calcular y retornar el área de un polígono.
 * - La función recibirá por parámetro sólo UN polígono a la vez.
 * - Los polígonos soportados serán Triángulo, Cuadrado y Rectángulo.
 * - Imprime el cálculo del área de un polígono de cada tipo.
 */

namespace Ejercicio_5_v2
{
    class Ejercicio_5_v2
    {
        static void Main()
        {
            Poligono triangulo = new Triangulo(5, 3);
            Poligono cuadrado = new Cuadrado(5);
            Poligono rectangulo = new Rectangulo(5, 3);

            System.Console.WriteLine("Area de un Triangulo: " + AreaPoligono(triangulo));
            System.Console.WriteLine("Area de un Cuadrado: " + AreaPoligono(cuadrado));
            System.Console.WriteLine("Area de un Rectangulo: " + AreaPoligono(rectangulo));

        }

        static double AreaPoligono(Poligono poligono)
        {
            return poligono.PrintArea();
        }

        interface Poligono
        {
            public double PrintArea();
        }

        class Triangulo : Poligono
        {
            private double _base;
            private double _height;

            public Triangulo(double _base, double _height)
            {
                this._base = _base;
                this._height = _height;
            }

            public double PrintArea()
            {
                return (_base * _height) / 2;
            }
        }

        class Cuadrado : Poligono
        {
            private double _side;

            public Cuadrado(double _side)
            {
                this._side = _side;
            }

            public double PrintArea()
            {
                return _side * _side;
            }
        }

        class Rectangulo : Poligono
        {
            private double _side1;
            private double _side2;

            public Rectangulo(double _side1, double _side2)
            {
                this._side1 = _side1;
                this._side2 = _side2;
            }

            public double PrintArea()
            {
                return _side1 * _side2;
            }
        }
    }
}