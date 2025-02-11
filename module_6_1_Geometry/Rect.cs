using Geometry;
using System;

namespace Geometry
{
    class Rect : Shape
    {
        //Fdata fd;

        public double a {
            get { return fd.a; }
            set { fd.a = value;}
        }
        public double b
        {
            get { return fd.b; }
            set { fd.b = value; }
        }
        public Rect(Fdata fd) : base(fd)
        {
            //this.fd = fd;
            this.fd.type = Figures.Rect;
            this.fd.color = fd.color;
        }

        public override double Area()
        {
            return a * b; 
        }
/*        public override void Move(int dx, int dy)
        {
            fd.x0 += dx;
            fd.y0 += dy;
        }*/
        public override void PrintInfo()
        {
            base.PrintInfo();
            //Console.Write(fd.type + ":" + fd.x0 + "," + fd.y0 + " color=" + fd.color);
            Console.WriteLine(" a="+a+" b="+b);
        }
    }
}
