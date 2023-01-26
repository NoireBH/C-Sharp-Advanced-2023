using System;

namespace PlayersAndMonsters
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            SoulMaster soulmaster = new SoulMaster("Gosho", 1);

            Console.WriteLine(soulmaster);
        }
    }
}
