using System;
using Unit4.CollectionsLib;

class MainClass
{
    public static void Main(string[] args)
    {
        Queue<int> q = new Queue<int>();
        q.Insert(3);
        q.Insert(7);
        q.Insert(3);
        q.Insert(7);
        q.Insert(3);
        Change(q);
        while (!q.IsEmpty())
        {
            Console.Write("{0} ", q.Remove());

        }
    }

    public static void Change(Queue<int> q)
    {
        Queue<int> t = new Queue<int>();
        while (!q.IsEmpty())
        {
            t.Insert(q.Remove());

        }
        int x = t.Remove();
        q.Insert(x);
        int y;
        while (!t.IsEmpty())
        {
            y = t.Head();
            if (IsAbs(t, x))
            {
                q.Insert(y);
                q.Insert(y);
            }
            else
            {
                q.Insert(y);
            }
            x = y;
        }
    }
    public static bool IsAbs(Queue<int> q, int x)
    {
        int y = q.Remove();
        if (q.IsEmpty())
        {
            return false;
        }

        return ((y > x && y > q.Head()) || (y < x && y < q.Head()));

    }

}