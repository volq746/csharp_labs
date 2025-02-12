using System;
using System.Reflection;
using System.Text;

namespace module_7_1
{
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; } = "";

        public Person(int id, string name)
        {
            Name = name;
            Id = id;
        }

        ~Person()
        {
            Console.WriteLine("Запуск деструктора Person");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Type typeStringBuilder = typeof(StringBuilder);
            Console.WriteLine(typeStringBuilder.FullName);
            foreach (MethodInfo method in typeStringBuilder.GetMethods())
            {
                Console.WriteLine($"\t{method.DeclaringType} {method.MemberType} {method.Name}");
            }

            int i = 0;
            bool b = Convert.ToBoolean(i);
            Console.WriteLine(b);
            i = 4;
            b = Convert.ToBoolean(i);
            Console.WriteLine(b);

            Console.WriteLine($"Управляемая память:{GC.GetTotalMemory(false)}");
            Test1();
            Test2();
            GC.Collect();
            GC.WaitForPendingFinalizers();
            Console.WriteLine($"Управляемая память:{GC.GetTotalMemory(false)}");          
        }
        static void Test1()
        {
            Program program = new Program();
        }
        static void Test2()
        {
            Person person = new Person(4444, "Kirill");
        }


        ~Program()
        {
            Console.WriteLine("Запуск деструктора Program");
        }
    }
}
