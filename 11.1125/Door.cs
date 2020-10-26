using System;
using System.Collections.Generic;
using System.Reflection.PortableExecutable;
using System.Runtime.CompilerServices;
using System.Text;

namespace _11._1125
{
    class Door
    {
        static string model;
        static string color;
        static bool manuel_lock;
        static bool eye_hole;
        static int sec_level;

        static int level_ret()
        {
            int level = 0;
            level = (7 * sec_level);
            if (eye_hole)
                level += 5;
            else if (manuel_lock)
                level += 10;
            return level;
        }
        static int GetSec_Level()
        {
            return sec_level;
        }
    }
}
