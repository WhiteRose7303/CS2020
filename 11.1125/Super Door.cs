using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace _11._1125
{
    class Super_Door
    {
        public static Agent[] workers = new Agent[20];

        public static string Month(int target)
        {
            int sales = 0;
            for (int i = 0; i < workers.Length; i++)
            {
                for (int j = 0; j < workers[i].doors.legnth; j++)
                {
                    if (workers[i].doors[j] != null)
                        sales++;
                }
            }
            return sales;
        }
    }
}
