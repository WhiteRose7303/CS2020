using System;

namespace Ex_11._11411_All_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[10];
        }
        public int lastoffvalue(int[] arr)
        {
            int save = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i]%2 == 0)
                {
                    save = arr[i];
                }
            }
            return save;
        }
    }
}
