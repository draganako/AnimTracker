using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CassandraDataLayer.QueryEntities
{
    public class Unos
    {
       

        public double hrana { get; set; }
        public double voda { get; set; }

        public double tezina { get; set; }
        public string dan { get; set; }
        public string mesec { get; set; }
        public string godina { get; set; }
        public int vreme { get; set; }
        public string zivotinjaID { get; set; }

        public Unos()
        {

        }

        public Unos(string zivotinjaID, double voda, double hrana, double tezina, int vreme, int dan, int mesec, int god)
        {
            this.zivotinjaID = zivotinjaID;
            this.tezina = tezina;
            this.voda = voda;
            this.hrana = hrana;
            this.vreme = vreme;
            this.dan = dan.ToString();
            this.mesec = mesec.ToString();
            this.godina = god.ToString();
        }
    }

}
