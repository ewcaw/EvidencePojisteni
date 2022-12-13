namespace PokusEvidence
{
    class Program
    {
        
        static void Main(string[] args)
        {
            // instalace evidence
            Evidence evidence = new Evidence();
            //
            Console.WriteLine("________________________________");
            Console.WriteLine("Vítejte v Evidenci pojištění");
            Console.WriteLine("¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯");
            char volba = '0';

            // DOPLNIT SEZNAM
            //hlavní cyklus
            while (volba != '4')
            {
                Console.WriteLine();
                Console.WriteLine("*****************************");
                Console.WriteLine("Vyberte si akci:");
                Console.WriteLine("1 - Přidat nového Pojistného");
                Console.WriteLine("2 - Vypsat všechny Pojistné");
                Console.WriteLine("3 - Vyhledat Pojistného");
                Console.WriteLine("4 - Konec");
                volba = Console.ReadKey().KeyChar;
                Console.WriteLine();
                // reakce na volbu 
                
                switch (volba)
                {
                    case '1':
                        evidence.PridejZaznam();
                        break;
                    case '2':
                        evidence.VypisVse();
                        break;
                    case '3':
                        evidence.NajdiPojistence();
                        break;
                    case '4':
                        Console.WriteLine("Libovolnou klávesou ukončíte program");
                        break;
                    default:
                        Console.WriteLine("Neplatná volba, stiskněte libovolnou klávesu a opakujte volbu.");
                        break;
                        

                }
                
            }

        }
    }
}