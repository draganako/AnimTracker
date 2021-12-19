using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CassandraDataLayer.QueryEntities
{
    public class Korisnik
    {
        public string korisnikID { get; set; }
        public string ime { get; set; }
        public string prezime { get; set; }
        public string korisnicko { get; set; }
        public string lozinka { get; set; }

        public Korisnik()
        {

        }

        public Korisnik(string id, string ime, string prezime, string korisnicko, string lozinka)
        {
            this.korisnikID = id;
            this.ime = ime;
            this.prezime = prezime;
            this.korisnicko = korisnicko;
            this.lozinka = lozinka;
        }
    }
}
