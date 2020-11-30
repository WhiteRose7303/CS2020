using System;

namespace Test1
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //this is a remark
            int n = 1;
            int i = 1;
            int[] age = new int[n];
            input:
            Console.Write("Insert age... ");
            int b = int.Parse(Console.ReadLine());
            if (b == -1)
            {
                goto end;
            }
            else
            {
                age[i] = b;
                n++;
                i++;
                goto input;
            }

           
                
            
                
            end:
            Console.WriteLine("FUCK YOU!");
        }
    }
}
