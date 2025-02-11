using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
    internal abstract class Shape
    {
        protected Fdata fd;
        public void Move(int dx, int dy)
        {
            fd.x0 += dx;
            fd.y0 += dy;
        }
        public abstract double Area();
        /*        {
                    return 0;
                }*/
        public virtual void PrintInfo()
        {
            Console.Write(fd.type + ":" + fd.x0 + "," + fd.y0 + " color=" + fd.color);
        }

        public Shape(Fdata fd)
        {
            this.fd = fd;
        }
    }
}
