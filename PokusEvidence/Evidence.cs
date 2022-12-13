using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokusEvidence
{
    class Evidence
    {
        private Databaze databaze;

        public Evidence()
        {
            databaze = new Databaze();
        }

        private string ZjistiJmeno()
        {
            Console.WriteLine("Zadejte jméno:");
            string firstName;
            while (string.IsNullOrWhiteSpace(firstName = Console.ReadLine()))
            {
                Console.WriteLine("Zadejte text znovu:");
            }
            return firstName.ToLower().Trim();
        }

        private string ZjistiPrijmeni()
        {
            Console.WriteLine("Zadej příjmení:");
            string lastName;
            while (string.IsNullOrWhiteSpace(lastName = Console.ReadLine()))
            {
                Console.WriteLine("Zadejte text znovu:");
            }
            return lastName.ToLower().Trim();
        }

        private string ZjistiTelefon()
        {
            Console.WriteLine("Zadej telefoní číslo:");
            string phone;
            while (string.IsNullOrWhiteSpace(phone = Console.ReadLine()))
            {
                Console.WriteLine("Zadejte text znovu:");
            }
            return phone.ToLower().Trim();
        }

        public int ZjistiVek()
        {
            Console.WriteLine("Zadej věk:");
            int age;
            while (!int.TryParse(Console.ReadLine(), out age))
            {
                Console.WriteLine("Neplatný formát, zadejte číslo");
            }
            return age;
        }

        public void PridejZaznam()
        {
            Console.WriteLine();
            string firstName = ZjistiJmeno();
            string lastName = ZjistiPrijmeni();
            string phone = ZjistiTelefon();
            int age = ZjistiVek();
            databaze.PridejPojistence(firstName,lastName,phone,age);
            Console.WriteLine("Data byla uložena. Prosím pokračujte libovolnou klávesou.");
            Console.ReadKey();
            
        }

        public void VypisVse()
        {
            Console.WriteLine();
            Console.WriteLine("Výpis všech pojištěných");
            databaze.NajdiZaznamy();
            
        }

        
        public void NajdiPojistence()
        {
            Console.WriteLine();
            Console.WriteLine("Vyhledání pojištence dle jména a příjmení:");
            //Zjištění údajů
            string firstName = ZjistiJmeno();
            string lastName = ZjistiPrijmeni();
            databaze.NajdiDleJmena(firstName,lastName);
            
        }
        
        

            

	}

          
}
