using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CassandraDataLayer.QueryEntities
{
    class Problemi
    {
        public string problemID { get; set; }
        public double kolicinaVode { get; set; }
        public double kolicinaHrane { get; set; }
        public double tezina { get; set; }
    }
}
