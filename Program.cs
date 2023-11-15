namespace Laboration_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Meny = 0;
            while (Meny !=3)
            { 
                Console.WriteLine(
                    "\n" + "Välj ett av alternativen: " + 
                "\n1.) Lägg till husdjur och sortera dem i bokstavsordning" +
                "\n2.) Slumpa fram en lottorad" +
                "\n3. ) Avsluta" +
                "------------------------------------------------"
                );
                Meny = Int32.Parse(Console.ReadLine());

                switch (Meny)
                {
                  case 1:
                    string[] Namn = new string[5];
                    Console.WriteLine("Ange namnen på fem familjemedlemmar");
                        for (int i = 0; i < Namn.Length; i++)
                            {
                            Console.WriteLine($"vad heter familjemedlem nummer {i + 1}?");
                            Namn[i] = Console.ReadLine();
                            }


                        }



            
        }
    }
}