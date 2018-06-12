using System;

namespace HW14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int slick = 23;
            int rick = 27;
            string sayWhatsGood = "say it!";
            string sayWhats = "say it 2";
            float number = 0.45f;
            double number2 = 0.35;
            bool number3 = true;
            Console.WriteLine(slick);
            Console.WriteLine(rick);
            Console.WriteLine(sayWhatsGood);
            Console.WriteLine(sayWhats);
            Console.WriteLine(number);
            Console.WriteLine(number2);
            Console.WriteLine(number3);

            Console.WriteLine("frustration" == "frustration" && "slickrick" == "slickrick");
            Console.WriteLine(1 < 2);
            Console.WriteLine("slick" == "chill");
            Console.WriteLine(17 > 25);
            Console.ReadKey();
        }
    }
}
