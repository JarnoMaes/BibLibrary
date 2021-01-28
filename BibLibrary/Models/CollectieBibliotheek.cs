using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibLibrary.Models
{
    public static class CollectieBibliotheek
    {
        public static List<Lid> Leden = new List<Lid>();
        public static List<Item> ItemsInCollectie = new List<Item>();
        public static List<Item> AfgevoerdeItems = new List<Item>();
    }
}
