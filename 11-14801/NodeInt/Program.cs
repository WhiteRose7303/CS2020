using System;

namespace NodeInt
{
    class Program
    {
        static void Main(string[] args)
        {
            Nodeint n1 = new Nodeint(15);
            Nodeint n2 = new Nodeint(20,n1);
            Nodeint n3 = new Nodeint(-1,n2);
            Nodeint n4 = new Nodeint(5,n3);
            Console.WriteLine(Print(n4));
            Console.WriteLine(Print(RetNoNeg(n4)));
            Console.WriteLine(alabama(n4));
            
        }
        public static string Print(Nodeint n)
        {
            Nodeint n1;
            n1 = n;
            string str = "";
            str = str + n1.ToString() + " ";
            while (n1.HasNext())
            {
                n1 = n1.GetNext();
                str = str + n1.ToString() + " ";
            }
            return str;

        }
        public static Nodeint RetNoNeg(Nodeint n)
        {
            Nodeint nt;
            Nodeint nextnt;
            nt = n;
            while (nt.HasNext())
            {
                nextnt = nt.GetNext();
                if (nextnt.GetValue() < 0)
                    nt.SetNext(nextnt.GetNext());
                nt = nt.GetNext();
            }
            return n;
        }
        public static int alabama(Nodeint n)
        {
            Nodeint nt;
            nt = n;
            int sum = 0;
            while (nt.HasNext())
            {
                sum += nt.GetValue();
                nt = nt.GetNext();
            }
            sum += nt.GetValue();
            return sum;
        }

    }
}
