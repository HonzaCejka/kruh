using System;

namespace kruh
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true) 
            {
                Console.Clear();

                int vyber;
                double input;
                double pi = 3.14;
                double obvod;
                double obsah;

                Console.WriteLine("kruh");
                Console.WriteLine("─────────────────────────");
                Console.WriteLine("1.zadání poloměru");
                Console.WriteLine("2.zadání průměru");
                vyber = int.Parse(Console.ReadLine());

                if (vyber == 1)
                {
                    Console.Write("zadejte poloměr (r) ");


                }
                else if (vyber == 2)
                {
                    Console.Write("zadejte průměr (d) ");
                }
                else
                {
                    Console.WriteLine("vyberte z nabídky");
                    break;
                }

                while (!double.TryParse(Console.ReadLine(), out input))
                    Console.WriteLine("zadejte číslo!");

                input = Math.Round(input, 1);
                if (vyber == 2)
                {
                    input = input / 2;
                }

                obvod = 2 * pi * input;
                obvod = Math.Round(obvod, 1);

                obsah = pi * input * input;
                obsah = Math.Round(obsah, 1);

                Console.WriteLine($"Obvod je: {obvod} cm");
                Console.WriteLine($"Obsah je: {obsah} cm");
                Console.ReadLine();
            }
            

        }

    }
}
