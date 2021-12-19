namespace CassandraDataLayer.QueryEntities
{
    public class Bolest
    {
        public string bolestID { get; set; }

        public string naziv { get; set; }
        public double kolicinaVode { get; set; }
        public double kolicinaHrane { get; set; }
        public double tezina { get; set; }

        public string vrstaId { get; set; }

        public string opis { get; set; }

        public Bolest() { }

        public Bolest(string naziv, double kolicinaVode, double kolicinaHrane, double tezina, string vrstaId, string opis)
        {
            this.naziv = naziv;
            this.kolicinaVode = kolicinaVode;
            this.kolicinaHrane = kolicinaHrane;
            this.tezina = tezina;
            this.vrstaId = vrstaId;
            this.opis = opis;
        }
    }
}
