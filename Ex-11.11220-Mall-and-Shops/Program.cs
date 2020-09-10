using System;

namespace Ex11.MallandShops
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            
        }
    }
    class mall
    {
        public static shop[] shops = new shop[200];

        public static bool CheckName(string name, shop[] shops)
        {
            for (int i = 0; i < shops.Length; i++)
            {
                if (shops[i].GetName()==name)
                {
                    return true;
                }
            }
            return false;
        }
        public static bool CheckMost(shop[] shops)
        {
            int count = 0;
            for (int i = 0; i < shops.Length; i++)
            {
                if(shops[i].GetPayed() == true)
                {
                    count++;
                }
                if (count >= 100)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

    }
    class shop
    {
        public static string name;
        public static int space;
        public static int rent;
        public static bool payed;

        public static int GetRentForM()
        {
            int total = 0;
            total = rent / space;
            return total;
        }
    }
}
