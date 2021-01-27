using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibLibrary.Models
{
    public enum SoortItem
    {
        Boek,
        Stripverhaal,
        Dvd,
        CD
    }
    public class Item
    {
        private int _Id = 0;      
        public int ItemId { get; set; }
        public string Titel { get; set; }
        public SoortItem SoortItem { get; set; }
        public string Auteur { get; set; }
        public string Reggisseur { get; set; }
        public string Uitvoerder { get; set; }
        public int Jaartal { get; set; }
        public bool Uitgeleend { get; set; }
        public bool Afgevoerd { get; set; }

        public Item()
        {
            ItemId = _Id;
            _Id++;
        }
        public Item(string titel,SoortItem soortitem,string auteur,string reggiseur,string uitvoerder,int jaartal,bool uitgeleend,bool afgevoerd):this()
        {
            this.Titel = titel;
            this.SoortItem = soortitem;
            this.Auteur = auteur;
            this.Reggisseur = reggiseur;
            this.Uitvoerder = uitvoerder;
            this.Jaartal = jaartal;
            this.Uitgeleend = uitgeleend;
            this.Afgevoerd = afgevoerd;
        }
        public override string ToString()
        {
            return $"{ItemId} / {Titel} / {SoortItem}" +
                $"\n{Auteur} / {Reggisseur} / {Uitvoerder} / {Jaartal}" +
                $"\n {Uitgeleend} / {Afgevoerd}";
        }
    }
}
