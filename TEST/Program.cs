using System;

namespace TEST
{
    class Program
    {
        static void Main(string[] args)
        {
        start:
            Console.WriteLine("this is a test");
            string test = Console.ReadLine();
            if (test == "start")
            {
                Console.WriteLine("test is complete ");
            }
            else
            {
                Console.WriteLine("wrong ");
                goto start;
            }
            
        }
    }
}
