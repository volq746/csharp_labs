using System.Numerics;

namespace module_8_1
{
    internal class Program
    {
        public static bool factorial(int n, out long fac)
        {
            fac = 1;
            try
            {
                for (int i = 1; i <= n; ++i)
                {
                    checked { fac *= i; }
                }
                return true;
            }
            catch
            {
                return false;
            }
        }
        public static bool factorial(int n, out BigInteger fac)
        {
            fac = 1;
            for (int i = 1; i <= n; ++i)
            {
                fac *= i;
            }
            return true;
        }



        static void Main(string[] args)
        {
            int i = 20000;
            try
            {
                if (!factorial(i, out long fac)) throw new OverflowException("Переполнение результата");
                else Console.WriteLine($"Факториал числа {i} = {fac}");
            }
            catch (OverflowException e) { Console.WriteLine(e.Message); }
            catch (Exception e) { Console.WriteLine(e.Message); }
            BigInteger bi = new BigInteger();
            try
            {
                factorial(i, out bi);
                Console.WriteLine($"Факториал числа {i} = {bi}");
            }
            catch (Exception e) {Console.WriteLine(e.Message); }
        }
    }
}
