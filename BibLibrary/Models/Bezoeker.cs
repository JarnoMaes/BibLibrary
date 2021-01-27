using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibLibrary.Models
{
    public class Bezoeker
    {
        public string VoorNaam { get; set; }
        public string FamilieNaam { get; set; }

        public Bezoeker(string voornaam, string familienaam)
        {
            this.VoorNaam = voornaam;
            this.FamilieNaam = familienaam;
        }

        public void RegistreerAlsLid(DateTime geboortedatum)
        {
            CollectieBibliotheek.Leden.Add(new Lid(geboortedatum, VoorNaam, FamilieNaam));
        }
        public Item ZoekItem(string titel) // Fout in code
        {
           return CollectieBibliotheek.ItemsInCollectie.Find(item.Titel);
        }
        public void ToonOverzicht() // Moesten we dit zo doen of met de collection werken ?
        {
            Console.WriteLine("Kies uit welk overzicht !" +
                "\nA: Alle Beschikbare Items" +
                "\nB: Items dat momenteel niet beschikbaar zijn" +
                "\nC: Alle afgevoerde Items" +
                "\nD: Alle Items in de collectie");
            string Keuze = Console.ReadLine();
            if (Keuze.ToUpper() == "A")
            {
                Console.WriteLine("Alle Beschikbare Items");
                foreach (var item in CollectieBibliotheek.ItemsInCollectie)
                {
                    Console.WriteLine($"Item Id: {item.ItemId}" +
                        $"\nItem Titel: {item.Titel}" +
                        $"\nSoort Item: {item.SoortItem}" +
                        $"\nItem Auteur: {item.Auteur}" +
                        $"\nItem Reggiseur: {item.Reggisseur}" +
                        $"\nItem Uitvoerder: {item.Uitvoerder}" +
                        $"\nItem Jaartal: {item.Jaartal}" +
                        $"\nItem Uitgeleend: {item.Uitgeleend}" +
                        $"\nItem Afgevoerd: {item.Afgevoerd}");
                }
            }
            else if (Keuze.ToUpper() == "B")
            {
                Console.WriteLine("Items dat momenteel niet beschikbaar zijn");
                foreach (var item in CollectieBibliotheek.ItemsInCollectie)
                {
                    if (item.Uitgeleend)
                    {
                        Console.WriteLine($"Item Id: {item.ItemId}" +
                        $"\nItem Titel: {item.Titel}" +
                        $"\nSoort Item: {item.SoortItem}" +
                        $"\nItem Auteur: {item.Auteur}" +
                        $"\nItem Reggiseur: {item.Reggisseur}" +
                        $"\nItem Uitvoerder: {item.Uitvoerder}" +
                        $"\nItem Jaartal: {item.Jaartal}" +
                        $"\nItem Uitgeleend: {item.Uitgeleend}" +
                        $"\nItem Afgevoerd: {item.Afgevoerd}");
                    }
                }
            }
            else if (Keuze.ToUpper() == "C")
            {
                Console.WriteLine("Items dat zijn afgevoerd");
                foreach (var item in CollectieBibliotheek.ItemsInCollectie)
                {
                    if (item.Afgevoerd)
                    {
                        Console.WriteLine($"Item Id: {item.ItemId}" +
                        $"\nItem Titel: {item.Titel}" +
                        $"\nSoort Item: {item.SoortItem}" +
                        $"\nItem Auteur: {item.Auteur}" +
                        $"\nItem Reggiseur: {item.Reggisseur}" +
                        $"\nItem Uitvoerder: {item.Uitvoerder}" +
                        $"\nItem Jaartal: {item.Jaartal}" +
                        $"\nItem Uitgeleend: {item.Uitgeleend}" +
                        $"\nItem Afgevoerd: {item.Afgevoerd}");
                    }
                }
            }
            else if (Keuze.ToUpper() == "D")
            {
                Console.WriteLine("Alle items in de Collectie");
                foreach (var item in CollectieBibliotheek.ItemsInCollectie)
                {
                    Console.WriteLine($"Item Id: {item.ItemId}" +
                        $"\nItem Titel: {item.Titel}" +
                        $"\nSoort Item: {item.SoortItem}" +
                        $"\nItem Auteur: {item.Auteur}" +
                        $"\nItem Reggiseur: {item.Reggisseur}" +
                        $"\nItem Uitvoerder: {item.Uitvoerder}" +
                        $"\nItem Jaartal: {item.Jaartal}" +
                        $"\nItem Uitgeleend: {item.Uitgeleend}" +
                        $"\nItem Afgevoerd: {item.Afgevoerd}");
                }
            }
        }
    }
}
