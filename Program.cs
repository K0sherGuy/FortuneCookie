using System;

namespace FortuneCookie
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] cookie = { "win a jackpot", "fall in love", "get a love letter", "miss the bus", "see a unicorn on the street" };

            Random rnd = new Random();
            int randomCookie = rnd.Next(0, cookie.Length);

            Console.WriteLine($"Cookie saying you {cookie[randomCookie]}");
        }
    }
}
