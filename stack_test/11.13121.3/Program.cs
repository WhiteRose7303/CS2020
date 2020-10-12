using System;
using Unit4.CollectionsLib;

namespace Application
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Stack<int> s = new Stack<int>();
            s.Push(54);
            s.Push(44);
            s.Push(4);
            s.Push(5);
            s.Push(55);
            equl(s);
        }
        public static bool equl(Stack<int> s)
        {
            int zugi = 0;
            int nozugi = 0;
            while (!s.IsEmpty())
            {
                int x = s.Pop();
                int l = x.ToString().Length;
                if (l%2==0)
                {
                    zugi++;
                }
                else
                {
                    nozugi++;
                }
                if (zugi == nozugi)
                {
                    return true;
                }
                else { return false; }
            }
            return false;
        }
            
    }
}
