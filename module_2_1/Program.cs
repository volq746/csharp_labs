namespace module_2_1
{
    enum Figures
    {
        Romb,
        Circle,
        Rect,
        Square,
        Line
    }

    struct Fdata
    {
        public int x0, y0;      // координаты центра тяжести
        public int color;       // цвет фигуры
        public Figures type;    // тип фигуры
        public void PrintFdata()
        {
            Console.WriteLine($"Типа фигуры:\t{type}\n" +
                $"Координаты центра тяжести:\tx = {x0}, y = {y0}\n" +
                $"Цвет фигуры:\t{color}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Fdata fd1 = new Fdata()
            {
                x0 = 1,
                y0 = 1,
                color = 0x2727ff,
                type = Figures.Romb,
            };

            fd1.PrintFdata(); // Выводим в консоль данные по fd1
        }
    }
}
