using System;

namespace TEST
{
    class Program
    {
        static void Main(string[] args)
        {
            TET:
            Console.WriteLine("test is complete");
            int count = 0, tens;
            for (int i = 0; i<=199; i++)
            {
                tens = (i / 10) % 10;
                if ((tens == 3) || (tens == 7))
                {
                    count++;
                }
            }
            Console.WriteLine(count);
            goto TET;
        }
    }
}
