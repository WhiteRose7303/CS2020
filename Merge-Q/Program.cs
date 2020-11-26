using System;
using Unit4.CollectionsLib;

class MainClass
{
    public static void Main(string[] args)
    {
        Queue<int> q1 = new Queue<int>();
        Queue<int> q2 = new Queue<int>();
        Queue<int> Sorted = new Queue<int>();
        q1.Insert(5);
        q1.Insert(7);
        q1.Insert(8);
        q2.Insert(1);
        q2.Insert(2);
        q2.Insert(3);
        q2.Insert(8);
        Sorted = MergedQueue(q1, q2);
        while (!Sorted.IsEmpty())
        {
            Console.WriteLine(Sorted.Remove());
        }
    }

    // Complete the method below
    public static Queue<int> MergedQueue(Queue<int> q1, Queue<int> q2)
    {
        Queue<int> Merged = new Queue<int>();
        int x;
        while (!q1.IsEmpty() && !q2.IsEmpty())
        {
            x = Math.Min(q1.Head(), q2.Head());
            if (q1.Head() == q2.Head())
            {
                Merged.Insert(q1.Remove());
                q2.Remove();
            }
            else
            {
                Merged.Insert(x);
                if (x == q1.Head())
                {
                    q1.Remove();
                }
                else
                {
                    q2.Remove();
                }
            }
            if (q1.IsEmpty())
            {
                while (!q2.IsEmpty())
                {
                    Merged.Insert(q2.Head());
                    q2.Remove();
                }
            }
            if (q2.IsEmpty())
            {
                while (!q1.IsEmpty())
                {
                    Merged.Insert(q1.Head());
                    q1.Remove();
                }
            }
        }
        return Merged;

    }

}