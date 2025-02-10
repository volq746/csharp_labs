namespace module_4_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            foreach (string arg in args) // перечисление входных параметров в виде строк
            {
                Console.WriteLine(arg); 
            }

            int i;
/*            foreach (string arg in args) // если во входном параметре будет алфовитный символ, то возвращается исключение
            {
                i = int.Parse(arg);
                Console.WriteLine(i);
            }*/

            foreach (string arg in args) // Проверка  с условием
            {
                if (int.TryParse(arg, out i))
                    Console.WriteLine(i);
                else Console.WriteLine($"{arg} - Не число");
            }

        }
    }
}
