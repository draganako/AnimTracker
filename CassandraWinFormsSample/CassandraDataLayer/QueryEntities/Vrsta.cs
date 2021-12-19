using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CassandraDataLayer.QueryEntities
{
    public class Vrsta
    {
        public string vrstaID { get; set; }
        public string nazivvrste { get; set; }

        public string maximumHrana { get; set; }
        public string maximumTezina { get; set; }
        public string maximumVoda { get; set; }

        public string minimumHrana { get; set; }
        public string minimumTezina { get; set; }
        public string minimumVoda { get; set; }

        public string opis { get; set; }

        public string standardHrana { get; set; }
        public string standardTezina { get; set; }
        public string standardVoda { get; set; }


        public Vrsta()
        { }
        public Vrsta(string standardTezina, string minimumTezina, string maximumTezina, string standardHrana, string minimumHrana,
            string maximumHrana, string standardVoda, string minimumVoda, string maximumdVoda, string opis, string nazivvrste)
        {
            this.nazivvrste = nazivvrste;
            this.maximumHrana = maximumHrana;
            this.maximumTezina = maximumTezina;
            this.maximumVoda = maximumdVoda;

            this.minimumHrana = minimumHrana;
            this.minimumTezina = minimumTezina;
            this.minimumVoda = minimumVoda;
            this.opis = opis;

            this.standardHrana = standardHrana;
            this.standardTezina = standardTezina;
            this.standardVoda = standardVoda;

        }
        public Vrsta(string id,string standardTezina, string minimumTezina, string maximumTezina, string standardHrana, string minimumHrana,
            string maximumHrana, string standardVoda, string minimumVoda, string maximumdVoda, string opis, string nazivvrste)
        {
            this.vrstaID = id;
            this.nazivvrste = nazivvrste;
            this.maximumHrana = maximumHrana;
            this.maximumTezina = maximumTezina;
            this.maximumVoda = maximumdVoda;

            this.minimumHrana = minimumHrana;
            this.minimumTezina = minimumTezina;
            this.minimumVoda = minimumVoda;
            this.opis = opis;

            this.standardHrana = standardHrana;
            this.standardTezina = standardTezina;
            this.standardVoda = standardVoda;

        }
    }   
}
