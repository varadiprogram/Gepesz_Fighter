using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Gépész Fighter

            int bulcsa = 1000;
            int levente = 2500;
            int varadi = 5000;
            int palfi = 7000;
            int hamvas = 9100;

            int sebzes = 0; // Támadásod ereje
            Random veletlen = new Random();

            Console.WriteLine("Gépész Fighter - El szeretnéd kezdeni a játékot? (igen/nem)");
            string kerdes = Console.ReadLine()?.ToLower();

            if (kerdes != "igen")
            {
                Console.WriteLine("Kilépés a játékból. Viszlát!");
                return;
            }

            // Erő gyűjtés
            for (int i = 5; i > 0; i--)
            {
                int szam = veletlen.Next(1, 2001);
                Console.WriteLine("Erő: " + szam);
                sebzes += szam;
                Console.WriteLine("Nyomj egy entert a folytatáshoz...");
                Console.ReadLine();
            }

            Console.WriteLine("Összesített erőd: " + sebzes);
            Console.WriteLine("Készen állsz harcolni az iskola legnagyobb arcai ellen?");

            Harc("Búlcsú", bulcsa, ref sebzes);
            Harc("Levente", levente, ref sebzes);
            Harc("Váradi", varadi, ref sebzes);
            Harc("Pálfi Máté", palfi, ref sebzes);
            Harc("Hamvas István (MAFFIA főnök)", hamvas, ref sebzes);

            Console.WriteLine("Gratulálok! Legyőztél mindenkit, most már mehetsz a béke szigetére.");
            Console.ReadLine();
        }

        static void Harc(string ellenfelNeve, int ellenfelEro, ref int sebzes)
        {
            Console.WriteLine($"\nAz ellenfeled: {ellenfelNeve} - Ereje: {ellenfelEro}");
            Console.WriteLine("Nyomj egy entert a harc megkezdéséhez...");
            Console.ReadLine();

            if (sebzes >= ellenfelEro)
            {
                Console.WriteLine("Győztél, de ne feledd hogy ez egy játék és élőbe más lenne a szitúáció");
                Console.WriteLine("https://i1.sndcdn.com/artworks-YDQOy2Pru5CA2rhs-x1uzgA-t1080x1080.jpg"); //kep
            }
            else
            {
                Console.WriteLine("Vesztettél! Ezt nem fogod végig vinni");
                Console.WriteLine("https://media.tenor.com/pchViwotG9cAAAAM/hahahahah-gahahahaha.gif"); // gif
                Console.WriteLine("Majd beszelünk");
                Environment.Exit(0); // Kilép a programból, ha veszítesz
            }
        }
    }
}
