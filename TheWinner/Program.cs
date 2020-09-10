using System;

namespace TheWinner
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            
        }
        public static void TheWInner(Vote[] votes)
        {
            int count;
            int maxpoints = 0;
            int maxinex;
            for (int i = 0; i < 41; i++)
            {
                count = 0;
                for (int j = 0; j < votes.Length; j++)
                {
                    if (votes[j].GetFirst() == i)
                    {
                        count += 7;
                    }
                    if (votes[j].GetSeconed() == i)
                    {
                        count += 5;
                    }
                    if (votes[j].GetThied() == i)
                    {
                        count += 1;
                    }
                }
                if (count > maxpoints)
                {
                    maxpoints = count;
                    maxinex = i;
                }
            }
                Console.WriteLine(maxpoints)

        }
    }
}
