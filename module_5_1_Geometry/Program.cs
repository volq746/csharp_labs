using System;

namespace Geometry
{
    /// <summary>
    /// Базовый класс
    /// </summary>
    public class Info
    {
        public virtual void PrintInfo()
        {
            Console.WriteLine("Нет данных");
        }
    }
    public enum Figures { Romb, Rect, RightTriangle, Circle }

    public struct Fdata
    {
        public int x0, y0;
        public double a, b;
        public int color;
        public Figures type;
    }

    class Program
    {
        static void Main(string[] args)
        {
            Rect rect = new Rect(new Fdata() {x0=1,y0=1,a=3,b=5});
            rect.Move(2, 1);
            rect.PrintInfo();
            Console.WriteLine(rect.Area());

            RightTriangle rt = new RightTriangle(new Fdata() { x0 = -1, y0 = -3, a = 1, b = 4 });
            rt.Move(1, 1);
            rt.PrintInfo();
            Console.WriteLine(rt.Area());

            //Ваш код!
            Circle circle = new Circle(new Fdata() {x0 = 1, y0 = 3, a = 5});
            circle.Move(2, 3);
            circle.PrintInfo();
            Console.WriteLine(circle.Area());


            object[] data = {rect, rt, circle};
            Print(data);
        }

        public static void Print(object[] data)
        {
            foreach (Info o in data) // Приводим к типу базового класса
            {                
                   o.PrintInfo(); // Вызываем метод благодаря полиморфизму
            }
        }
    }
}
