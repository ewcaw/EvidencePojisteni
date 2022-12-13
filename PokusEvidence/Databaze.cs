using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokusEvidence
{
    class Databaze
    {
        private List<Pojistenec> pojistenci;

        public Databaze()
        {
            pojistenci = new List<Pojistenec>();
        }

        // Přidá pojištence a jeho údaje do listu
        public void PridejPojistence(string firstName, string lastName, string phone, int age)
        {
            pojistenci.Add(new Pojistenec(firstName, lastName, phone, age));
        }

        public void NajdiZaznamy()
        {
            foreach (Pojistenec pojistenec in pojistenci)
            {
                Console.WriteLine(pojistenec);
            }
        }

        public void NajdiDleJmena(string firstName, string lastName)
        {
            foreach (Pojistenec pojistenec in pojistenci)
            {
                if (pojistenec.FirstName == firstName && pojistenec.LastName == lastName)
                {
                    Console.WriteLine("Nalezený údaj:");
                    Console.WriteLine(pojistenec);
                }
                else
                {
                    Console.WriteLine("Nenalezeno");
                }
            }
        }

        
            
    }
}
