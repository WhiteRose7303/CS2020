using System;
using Unit4.CollectionsLib;

namespace BuildListNeg
{
    class Program
    {
        static void Main(string[] args)
        {
            Node<int> main = BuildList(1, 5);
            pri(main);
        }
        public static Node<int> BuildList(int x, int y)
        {
            Node<int> main = null, tmp = null;
            for (int i = x; i<= y; i++)
            {
                if (main == null)
                {
                    main = new Node<int>(i);
                    tmp = main;
                }
                else
                {
                    tmp.SetNext(new Node<int>(i));
                    tmp = tmp.GetNext();
                }
            }
            return main;
        }
        public static void pri(Node<int> l)
        {
            string str = "";
            while (l != null)
            {
                str = str + l.GetValue() + " --> ";
                l = l.GetNext();
            }
            str = str + "null";
            Console.WriteLine(str);
        }

    }

   
}
