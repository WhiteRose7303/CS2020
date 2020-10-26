using System;
using Unit4.CollectionsLib;
namespace Ex11._14701
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 1;
            Queue<int> q = new Queue<int>();
            q.Insert(1);
            q.Insert(1);
            q.Insert(2);
            q.Insert(6);
            q.Insert(8);
        }
        public static bool ret(Queue<int> q, int num)
        {
            int count = 0;
            while(!q.IsEmpty())
            {
                if (q.Head() == num)
                {
                    count++;
                }
                q.Remove();
            }
            if (count >= 2)
                return true;
            else
                return false;
        }
    }
}
