using System;

namespace Application
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            printup(8);  
        }
        static void printup(int n)
        {
            if (n > 1)
            {
                printup(n - 1);
            }
            Console.WriteLine(n);
        }
        static void printdown(int n)
        {
            
        }
    }
}
