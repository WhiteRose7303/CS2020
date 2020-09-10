using System;

namespace Ex11.CaliforniaFires
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            district[] districts = new district[58];
        }
        class fire
        {
            public static int windspeed;
            public static int humidity;
            public static int tempreture;

            public static void addrisk()
            {
                if (windspeed > 70)
                {
                    district.SetDanger(district.GetDanger + 1);
                    if (district.GetDanger() == 5)
                    {
                        district.SetDanger(5);
                    }
                }
                if (humidity < 30)
                {
                    district.SetDanger(district.GetDanger + 2);
                    if (district.GetDanger() == 5)
                    {
                        district.SetDanger(5);
                    }
                }
                if (tempreture > 100)
                {
                    int temp = 100 - tempreture;
                    int to = temp / 10;
                    district.SetDanger(district.GetDanger + to);
                    if (district.GetDanger() == 5)
                    {
                        district.SetDanger(5);
                    }
                }
            }

        }
        class district
        {
            public static string name;
            public static int danger;
        }
    }
}
