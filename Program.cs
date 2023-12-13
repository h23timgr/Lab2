namespace Laboration_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Meny = 0;
            Console.WriteLine("Hur många familjemedlemmar har du?");
            int medlemmar = Convert.ToInt32(Console.ReadLine());

            Console.Clear();
            while (Meny != 3)
            { 
                Console.WriteLine(
                    "" + "Välj ett av alternativen: " + 
                    "\n1.) Skriv dina familjemedlemmars namn." +
                    "\n2.) Skriv åldern på familjemedlemmar och få deras sammanlagda ålder och medelålder utskrivet." +
                    "\n3. ) Avsluta och stäng ner programmet."
                    );
                Meny = Convert.ToInt32(Console.ReadLine());
                switch (Meny)
                {
                    case 1:
                        string[] Names = new string[medlemmar];
                        Console.WriteLine("Ange namnen på dina familjemedlemmar.");
                        for (int i = 0; i < Names.Length; i++)
                        {
                            Console.WriteLine($"vad heter familjemedlem nummer {i + 1}?");
                            Names[i] = Console.ReadLine()!;
                        }
                        Array.Sort(Names);
                        Console.WriteLine("-----------------------------------------\nDina familjemedlemmar i bokstavsordning:\n-----------------------------------------\n");
                        for (int i = 0; i < Names.Length; i++)
                        {
                            Console.WriteLine(Names[i]);
                        }
                        break;

                    case 2:
                        int[] Ages = new int[medlemmar];
                        Console.WriteLine("Ange ålder på dina familjemedlemmar.");
                        for (int i = 0; i < Ages.Length; i++)
                        {
                            Console.WriteLine($"Vilken ålder har familjemedlem nummer {i + 1}?");
                            Ages[i] = Convert.ToInt32(Console.ReadLine());
                        }
                        Console.WriteLine("-----------------------------------------\nDina familjemedlemmars Åldrar:\n-----------------------------------------\n");
                        for (int i = 0; i < Ages.Length; i++)
                        {
                            Console.WriteLine("{0} År ", Ages[i]);
                        }
                        int sum = Ages.Sum();
                        double medel = sum / medlemmar;
                        Console.WriteLine(" ");
                        Console.WriteLine("Den sammanlagda åldern är: " + sum);
                        Console.WriteLine($"Medelåldern för dina familjemedlemmar är: {medel:F2}");
                        break;

                    case 3:
                        Console.Clear();
                        Console.WriteLine("Tack för att du använde mitt program!");
                        break;
                    case 4:
                        break;

            }   }



            
        }
    }
}