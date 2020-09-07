using System;
using System.Collections.Generic;
using System.Data;
using System.Runtime.CompilerServices;
using System.Text;

namespace _11._10828_1
{
    class ArrN1N2
    {
        public static int[] arr;
        public static int n1;
        public static int n2;
        
        public ArrN1N2(int g1, int g2)
        {
            n1 = g1;
            n1 = g2;
            arr = new int[n1 + n2];
        }
        public static void fill()
        {
            for (int i = 0; i <n1; i++)
            {
                arr[i] = n1;
            }
            for (int i = n1; i<n2;i++)
            {
                arr[i] = n2;
            }
        }
    }
    
    
}
