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
            s.Push(-4);
            s.Push(-5);
            s.Push(-55);
            Console.WriteLine(negpos(s));

        }
        public static string negpos(Stack<int> s)
        {
            int pos = 0;
            int neg = 0;
            while (!s.IsEmpty())
            {
                int x = s.Pop();
                if (x < 0)
                {
                    int l = x.ToString().Length;
                    if (l % 2 == 0)
                    {
                        neg++;
                    }
                }
                else
                {
                    int l = x.ToString().Length;
                    if (l % 2 != 0)
                    {
                        pos++;
                    }
                }
                if (neg > pos)
                {
                    return "More Negative";
                }
                else
                {
                    return "More Positive";
                }
            }
            return "error";
        }
    }
}
