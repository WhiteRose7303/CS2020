using System;
using Unit4.CollectionsLib;

namespace Q6
{
    class GoremHeshboni
    {
        private char peula;
        private int mispar;
    }
    class Program
    {
        static void Main(string[] args)
        {
            
        }
        public static Queue<int> calc(Queue<GoremHeshboni> q)
        {
            GoremHeshboni temp;
            Queue<int> queue = new Queue<int>();
            int sum = 0;
            while(!q.IsEmpty())
            {
                temp = q.Remove();
                if (q.IsEmpty())
                {
                    return queue;
                }
                switch (temp.Getpeula())
                {
                    case '*':
                        queue.Insert(sum * temp.Getmispar());
                        break;
                    case '/':
                        queue.Insert(sum / temp.Getmispar());
                        break;
                    case '+':
                        queue.Insert(sum + temp.Getmispar());
                        break;
                    case '-':
                        queue.Insert(sum * temp.Getmispar());
                        break;
                }
                
            }
            return queue;
        }
    }
}
