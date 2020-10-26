using System;
using System.Collections.Generic;
using System.Text;

namespace _11._1125
{
    class Agent
    {
        static string name;
        public static Door[] doors = new Door[1000];

        static int good_doors(int level)
        {
            int good = 0;
            for (int i =0; i<doors.Length;i++)
            {
                if (doors[i] != null)
                {
                    if (doors[i].GetSec_Level() > level)
                    {
                        good++;
                    }
                }
            }
            return good;
        }
    }
}
