using System;
using Unit4.CollectionsLib;
namespace Stack_bagrut_1
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Stack<int> s = new Stack<int>();
            s.Push(9);
            s.Push(4);
            s.Push(7);
            s.Push(5);
            s.Push(5);
            s.Push(32);
            s.Push(6);
            s.Push(1);
            Console.WriteLine(addremove(s));
            Console.WriteLine(s.ToString());
            
        }
        public static int addremove(Stack<int> s)
        {
            Stack<int> s2 = new Stack<int>();
            while(!s.IsEmpty())
            {
                int x = s.Pop();
                s2.Push(x);
            }
            int ret = s2.Pop();
            while(!s2.IsEmpty())
            {
                int x = s2.Pop();
                s.Push(x);
            }
            return ret;
        }
    }

}
