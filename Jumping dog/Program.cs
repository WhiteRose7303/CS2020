using System;
using System.Security.Cryptography.X509Certificates;

namespace Jumping_dog
{
    class Program
    {
        //the class runs first the part without recursion and then runs the recursion part.
        //the function is *f(n) = f(n-3) + f(n-2) + f(n-1)*

        static void Main(string[] args)
        {            
            relo();
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

        //this section is whitout recursion 
        public static int[] Fibonacci(int number)
        {
            int[] a = new int[number+1];
            a[0] = 1;
            a[1] = 1;
            a[2] = 2;
            for (int i = 3; i < number+1; i++)
            {
                a[i] = a[i-3] + a[i - 2] + a[i - 1];
            }
            return a;
        }
        public static void relo()
        {
            int length = int.Parse(Console.ReadLine());
            var b = Fibonacci(length);
            foreach (var elements in b)
            {
                Console.WriteLine(elements);
            }
        }

    }
}
