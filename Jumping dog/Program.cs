using System;

namespace Jumping_dog
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("steps: ");
            int length = int.Parse(Console.ReadLine());
            for (int i = 0; i < length+1; i++)
                Console.Write("{0} ", dog(i));
        }
        static int dog(int n)
        {
            if (n == 0) return 1; 
            if (n == 1) return 1;
            if (n == 2) return 2;
            else
                return (dog(n - 1) + dog(n - 2) + dog(n - 3));
        }
       
    }
}
