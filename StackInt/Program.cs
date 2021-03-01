using System;

namespace StackInt
{
    class Program
    {
        static void Main(string[] args)
        {
            Stackint s1 = new Stackint();
            s1.Push(1);
            s1.Push(2);
            s1.Push(3);
            s1.Push(4);
            Console.WriteLine(s1.ToString());
            Console.WriteLine(s1.Top());
            s1.Pop();
            Console.WriteLine(s1.Top());
            Console.WriteLine(s1.ToString());
                
        }
    }
}
