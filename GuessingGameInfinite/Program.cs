using System;

namespace GuessingGameInfinite
{
    class Program
    {
        static void Main(string[] args)
        {

            //programm genereerib juhusliku numbri 1 kuni 10;
            //kasutaja peab selle numbri ära arvama;
            //kui kasutaja suutis selle numbri ära arvata, siis ta on mängu võitnud;
            //katsete arv on piiramatu.
            //programm genereerib juhuslikku numbrit üks kord.

            bool loopActive = true;

            Random rnd = new Random();
            int cpuNumber = rnd.Next(1, 11);

            while (loopActive)
            {
                Console.WriteLine("Sisesta arvatav number 1 - 10:");
                int userNumber = Convert.ToInt32(Console.ReadLine());

                if (userNumber == cpuNumber)
                {
                    Console.WriteLine("Sina võitsid mängu, palju õnne!");
                    loopActive = false;
                }

                else
                {
                    Console.WriteLine("Vale number. Proovi uuesti arvata.");
                }
            }


            Console.WriteLine("Kena päeva!");
        }
    }
}
