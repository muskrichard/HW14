﻿using System;

namespace HW14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hola!");
            

            int songtime = 5;
            int songdate = 5 / 23;
            int songyear = 2018;
            Console.WriteLine(songtime);
            Console.WriteLine("the song time is {0} and the song date was made on {1} and the song year is {2}",songtime, songdate, songyear);
            Console.ReadKey();

            string sayWhatsGood = "say it!";
            string sayWhats = "say it 2";
            Console.WriteLine(sayWhatsGood);
            Console.WriteLine(sayWhats);
            Console.ReadKey();

            float number = 0.45f;
            double number2 = 0.35;
            bool number3 = true;
            Console.WriteLine(number);
            Console.WriteLine(number2);
            Console.WriteLine(number3);
            Console.ReadKey();

            Console.WriteLine("frustration" == "frustration" && "slickrick" == "slickrick");
            Console.WriteLine(1 < 2);
            Console.WriteLine("slick" == "chill");
            Console.WriteLine(17 > 25);
            Console.ReadKey();
        }
    }
}
