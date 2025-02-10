using System;

namespace Geometry
{
    enum Figures { Romb, Rect, RightTriangle, Circle }
    struct Fdata
    {
        public int x0, y0;
        public double a, b;
        public int color;
        public Figures type;
    }
    class Program
    {
        static double area(Fdata fd)
        {
            double res = 0;
            res = fd.type switch
            {
                Figures.Romb => fd.a * fd.b, // a - сторона ромба, b - высота
                Figures.Rect => fd.a * fd.b, // a, b - стороны прямоугольника
                Figures.RightTriangle => (fd.a * fd.a * Math.Sqrt(3)) / 4, // a - сторона правильного треугольника
                Figures.Circle => Math.PI * fd.a * fd.a // a - радиус окружности
            };
            return res;
        }

        
        static void Main(string[] args)
        {
            Fdata fd = new Fdata() { a = 4, b = 3, type = Figures.Romb };
            Console.WriteLine(area(fd));
            Console.WriteLine("Ok");
        }
    }
}
