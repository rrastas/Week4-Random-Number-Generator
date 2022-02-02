using System;

namespace GuessingGameThreeTries
{
    class Program
    {
        static void Main(string[] args)
        {

            //programm genereerib juhusliku numbri 1 kuni 10;
            //kasutaja peab selle numbri ära arvama;
            //kui kasutaja suutis selle numbri ära arvata, siis ta on mängu võitnud;
            //kasutajal on kolm katset, kui kasutaja ei ole suutnud kolme katsega numbrit ära arvata,
            //siis mängu võidab arvuti.
            //programm genereerib juhuslikku numbrit üks kord.

            Random rnd = new Random();
            int cpuNumber = rnd.Next(1, 11);
            int i = 0;

            while (i < 3)
            {
                Console.WriteLine("Sisesta arvatav number 1 - 10:");
                int userNumber = Convert.ToInt32(Console.ReadLine());

                if (userNumber == cpuNumber)
                {
                    Console.WriteLine("Sina võitsid mängu, palju õnne!");
                    i = 3;
                }

                else if (i < 2)
                {
                    i++;
                    Console.WriteLine($"Vale number. Proovi uuesti arvata. Sul on jäänud {3 - i} katset");
                }

                else
                {
                    Console.WriteLine("Sul said katsed otsa. Mängu võitis arvuti.");
                    i = 3;
                }
            }

            Console.WriteLine("Kena päeva!");
        }
    }
}
