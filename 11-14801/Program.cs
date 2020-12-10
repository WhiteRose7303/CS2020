using System;
using Unit4.CollectionsLib;

namespace _11_14801
{
    class Program
    {
        static void Main(string[] args)
        {
            const string word = "coivd";
            Queue<char> q = String2Queue(word);
            printQueue(q);
            Console.WriteLine();
            q = String2Queue(word);
            printQueueReverse(q);
            Console.WriteLine();

        }
        public static Queue<char> String2Queue(string str)
        {
            Queue<char> q = new Queue<char>();
            for (int i = 0; i < str.Length; i++)
            {
                q.Insert(str[i]);
            }
            return q;
        }
        static void printQueue(Queue<char> q)
        {
            if (!q.IsEmpty())
            {
                Console.Write(q.Remove()+ "," + " ");
                printQueue(q);
            }
                
        }
        static void printQueueReverse(Queue<char> q)
        {
            if (!q.IsEmpty())
            {
                char a = q.Remove();
                printQueueReverse(q);
                Console.Write(a + ", ");
            }
        }
    }
}
