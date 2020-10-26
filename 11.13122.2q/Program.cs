using System;
using Unit4.CollectionsLib;

class MainClass
{
    public static void Main(string[] args)
    {

        // -------------- Test Code ---------------------------
        Queue<int> q1 = new Queue<int>();
        Queue<int> q2 = new Queue<int>();
        q1.Insert(55);
        q1.Insert(4);
        q1.Insert(215);
        q1.Insert(2);
        q1.Insert(11);

        bool b1 = ThreeInstances(q1, 5);
        int chksum = 0, p = 0;
        while (!q1.IsEmpty())
        {
            chksum = (chksum + (int)Math.Pow(q1.Head(), p % 3)) % 1000;
            p++;
            q2.Insert(q1.Remove());
        }
        if ((chksum == 242) && b1)
        {
            Console.WriteLine("T1: Passed");
        }
        else
        {
            Console.WriteLine("T1: Failed");
        }

        bool b2 = ThreeInstances(q2, 2);
        chksum = 0; p = 0;
        while (!q2.IsEmpty())
        {
            chksum = (chksum + (int)Math.Pow(q2.Head(), p % 3)) % 1000;
            p++;
            q1.Insert(q2.Remove());
        }
        if ((chksum == 242) && !b2)
        {
            Console.WriteLine("T2: Passed");
        }
        else
        {
            Console.WriteLine("T2: Failed");
        }
    }

    // --------------- End of Test Code --------------------------------

    // ---------------- Your Code --------------------------------------


    // Add your code in this method
    // Add more methods if necessary

    public static bool ThreeInstances(Queue<int> q, int d)
    {
        int instances = 0;
        Queue<int> q1 = new Queue<int>();
        while (!q.IsEmpty())
        {
            int num = q.Head();
            while ((num>9)||(num<-9))
            {
                if (num % 10 == d)
                    instances++;
                num = num / 10;
            }
            if (num == d)
                instances++;
            q1.Insert(q.Remove());
        }
        while(!q1.IsEmpty())
        {
            q.Insert(q1.Remove());
        }
        return (instances >= 3);
    }
  

    // ----------------- End of Your Code ---------------------------------



}