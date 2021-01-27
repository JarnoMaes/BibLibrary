using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibLibrary.Models
{
    public class Lid : Bezoeker
    {
        public DateTime GeboorteDatum { get; set; }
        public List<Item> UitleenHistoriek { get; set; }
        public List<Item> ItemsUitgeleend { get; set; }
        public List<Item> Reservatie { get; set; }

        public Lid(DateTime geboortedatum, string voornaam,string familienaam):base(voornaam,familienaam)
        {
            this.GeboorteDatum = geboortedatum;
        }

        public void Uitlenen(Item item)
        {
            if (ItemsUitgeleend.Count < 5)
            {
                ItemsUitgeleend.Add(item);
            }
            else
            {
                Console.WriteLine("Je hebt al meer als 5 items uitgeleend");
            }
        }
        public void Reserveren(Item item)
        {
            if (Reservatie.Count < 5)
            {
                Reservatie.Add(item);
            }
            else
            {
                Console.WriteLine("Al meer dan 5 items gereserveerd");
            }
        }
        public void TerugBrengen(Item item)
        {
            ItemsUitgeleend.Remove(item);
            UitleenHistoriek.Add(item);
        } 
    }
}
