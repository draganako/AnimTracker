using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CassandraDataLayer.QueryEntities
{
    public class Zivotinja
    {
        

        public Zivotinja(string ime, string vlasnikID, string pocTezina, string animalID, string vrstaID)
        {
            this.ime = ime;
            this.vlasnikID = vlasnikID;
            this.pocetnaTezina = pocTezina;
            this.animalID = animalID;
            this.vrstaID  = vrstaID;
        }

        public Zivotinja()
        {

        }
        public String ime { get; set; }
        public String vlasnikID { get; set; }
        public String pocetnaTezina { get; set; }

        public String animalID { get; set; }

        public String vrstaID { get; set; }
    }
}
