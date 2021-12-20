// See https://aka.ms/new-console-template for more information

namespace Hello
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            string name = "Amittai";
            int count = 0;

            while (++count < 10)
            {
                Console.WriteLine(name);
            }

            Console.ReadLine();
        }
    }
}
