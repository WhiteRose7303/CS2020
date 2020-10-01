using System;
using Unit4.CollectionsLib;
namespace stack_test
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Stack<int> s = new Stack<int>();
            Console.WriteLine(s.IsEmpty());
        }
    }
}
