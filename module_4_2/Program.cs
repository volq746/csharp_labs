using System.Text;

namespace module_4_1dop
{
    internal class Program
    {
        static string IntToBinary(int num)
        {
            int bit;
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < 32; i++)
            {
                if (i % 8 == 0) sb.Insert(0, " ");
                bit = (num >> i & 1) == 1 ? 1 : 0;
                sb.Insert(0,bit);
            }
            return sb.ToString();
        }
        static void Main(string[] args)
        {
            int num = 35145;
            Console.WriteLine($"{num} = {IntToBinary(num)}");
        }
    }
}
