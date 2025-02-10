using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
    class Circle : Info
    {
        Fdata fd;
        public double r
        {
            get { return fd.a; }
            set { fd.a = value; }
        }
        public void Move(int dx, int dy)
        {
            fd.x0 += dx;
            fd.y0 += dy;
        }
        public double Area()
        {
            return r * r * Math.PI;
        }
        public Circle(Fdata fd)
        {
            this.fd = fd;
            this.fd.type = Figures.Circle;
        }

        public override void PrintInfo() // Полиморфизм!
        {
            Console.Write($"{fd.type} : xy = {fd.x0},{fd.y0} color = {fd.color} ");
            Console.WriteLine($"radius = {r}");
        }

    }
}
