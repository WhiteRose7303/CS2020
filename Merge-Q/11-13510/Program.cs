using System;
using Unit4.CollectionsLib;

namespace _11_13510
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> q = new Queue<int>();
            q.Insert(-4);
            q.Insert(-4);
            q.Insert(2);
            q.Insert(3);
            q.Insert(0);
            q.Insert(0);
            q.Insert(0);
            q.Insert(0);
            q.Insert(5);
            q.Insert(5);

            Queue<int> result = CountBlocks(q);
            while(!result.IsEmpty())
            {
                Console.WriteLine(result.Head());
                result.Remove();
            }
            result = CountBlocks(q);
        }
        //the counter
        public static Queue<int> CountBlocks(Queue<int> q)
        {
            int x;
            int y;
            Queue<int> newq = new Queue<int>();
            while(!q.IsEmpty())
            {
                x = q.Head();
                y = HowManyTimes(q);
                if(y>1)
                {
                    newq.Insert(y * x);

                }
            }
            return newq;
        }

        public static int HowManyTimes(Queue<int> q)
        {
            int x = q.Remove();
            int counter = 1;
            while(!q.IsEmpty())
            {
                if (q.Head() == x)
                {
                    counter++;
                    q.Remove();
                }
                else
                    return counter;
            }
            return counter;
        }
    }
}
