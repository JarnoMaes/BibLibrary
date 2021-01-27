using BibLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleLibrary
{
    class Program
    {
        static void Main(string[] args)
        {
            Item i1 = new Item("Ole", SoortItem.Boek, "Scofield", "Michael", "Van Daele", 2000, false, false);
            Item i2 = new Item("Spoon", SoortItem.CD, "Spatel", "Mark", "De Lange", 1995, false, true);
            Item i3 = new Item("Mask", SoortItem.Dvd, "Daan", "De Wilde", "Neoks", 2020, true, false);
            Item i4 = new Item("Blubber", SoortItem.Stripverhaal, "Blubby", "De Blubber", "Blibs", 2012, true, true);
            
            CollectieBibliotheek.ItemsInCollectie.Add(i1);
            CollectieBibliotheek.ItemsInCollectie.Add(i2);
            CollectieBibliotheek.ItemsInCollectie.Add(i3);
            CollectieBibliotheek.ItemsInCollectie.Add(i4);

            Bezoeker b1 = new Bezoeker("Jarno", "Maes");
            Lid l1 = new Lid(new DateTime(1999, 27, 04), "Erwin", "Naegels");
            Medewerker m1 = new Medewerker("Jordy", "Maes", new DateTime(1995, 28, 08));

            CollectieBibliotheek.Leden.Add(l1);
            CollectieBibliotheek.Leden.Add(m1);
            

            b1.ToonOverzicht();
            b1.RegistreerAlsLid(new DateTime(1999, 27, 04));
            b1.ZoekItem("Ole");

            l1.ZoekItem("Spoon");
            l1.Reserveren(i3);
            l1.Uitlenen(i3);
            l1.TerugBrengen(i3);
            l1.ToonOverzicht();
            Console.WriteLine(l1.UitleenHistoriek);
            Console.WriteLine(l1.ItemsUitgeleend);
            Console.WriteLine(l1.Reservatie);

            m1.ZoekItem("Mask");
            m1.ToonOverzicht();
            m1.Uitlenen(i2);
            m1.Reserveren(i4);
            m1.TerugBrengen(i2);
            Console.WriteLine(m1.UitleenHistoriek);
            Console.WriteLine(m1.ItemsUitgeleend);
            Console.WriteLine(m1.Reservatie);
            m1.PromoveerLidNaarMedewerker(l1);
            

            /// Txt files heb ik nog wat meer uitleg bij nodig.
        }
    }
}
