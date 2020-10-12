using System;
using System.Security.Cryptography;

namespace TEST
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[10];
            Random r = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = r.Next(0, 10);
            }
            sum(arr, 6, 3);
    
        }
        static int sum(int[]arr, int i, int k)
        {
            if (i == arr.Length)
                return 0;
            else if (arr[i] > k)
                return arr[i] + sum(arr, i + 1, k);
            else
                return sum(arr, i + 1, k);
        }
    }
}
