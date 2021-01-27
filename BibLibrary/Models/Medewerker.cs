using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibLibrary.Models
{
    public class Medewerker : Lid
    {
        public Medewerker(string voornaam,string familienaam,DateTime geboortedatum):base(geboortedatum,voornaam,familienaam)
        {
            //CTOR erft van de base class(Lid)
        }
        public void PromoveerLidNaarMedewerker(Lid lid) //Fout In de code
        {
            CollectieBibliotheek.Leden.Remove(lid);
            CollectieBibliotheek.Leden.Add(new Medewerker(VoorNaam,FamilieNaam,geboortedatum));
        }
        public void VoerItemAf(Item item)
        {
            item.Afgevoerd = true;
            CollectieBibliotheek.ItemsInCollectie.Remove(item);
            CollectieBibliotheek.AfgevoerdeItems.Add(item);
        }
    }
}
