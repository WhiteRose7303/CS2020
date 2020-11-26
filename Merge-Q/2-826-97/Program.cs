using System;
using Unit4.CollectionsLib;

namespace Application
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Queue<double> q = new Queue<double>();
            q.Insert(1.5);
            q.Insert(2.2);
            q.Insert(-3.6);
            q.Insert(2);
            q.Insert(4.5);
            q.Insert(0.5);
            q.Insert(-6);
            q.Insert(-2.2);
            q.Insert(5.1);
            Queue<double> q2 = new Queue<double>();
            q2 = master(q);
            while(!q2.IsEmpty())
            {
                Console.WriteLine(q2.Head());
                q2.Remove();
            }
        }

        public static double pos(Queue<double> q)
        {
            double sum = 0;
            while (!q.IsEmpty() && q.Head()>=0) 
            {
                sum += q.Remove();
            }
            while (!q.IsEmpty() && q.Head() < 0)
            {
                q.Remove();
            }
            return sum;
            
        }
        public static Queue<double> master(Queue<double> q)
        {
            Queue<double> q1 = new Queue<double>();
            while (!q1.IsEmpty())
            {
                q1.Insert(pos(q));
            }
            return q1;
        }

    }
}
