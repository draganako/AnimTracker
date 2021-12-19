using Cassandra;
using CassandraDataLayer.QueryEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CassandraDataLayer
{
    enum vrstazaID
    {
        Zivotinja,
        Korisnik,
        Vrsta,
        Problem
    }
    public static class DataProvider
    {

        static String getID(vrstazaID vrsta)
        {
           // String s = "1";
            String id = "1";


            ISession session = SessionManager.GetSession();

            Row rr = null;
            if (vrsta == vrstazaID.Vrsta)
                rr = session.Execute("SELECT MAX(\"vrstaID\")  as max FROM \"Vrsta\" ").FirstOrDefault(); 
            else if(vrsta == vrstazaID.Zivotinja)
            {
                rr = session.Execute("SELECT MAX(\"zivotinjaID\")  as max FROM \"Zivotinja\" ").FirstOrDefault();
            }
            else if (vrsta == vrstazaID.Korisnik)
            {
                rr = session.Execute("SELECT MAX(\"korisnikID\")  as max FROM \"Korisnik\" ").FirstOrDefault();
            }
            else if (vrsta == vrstazaID.Problem)
            {
                rr = session.Execute("SELECT MAX(\"problemID\")  as max FROM \"PotencijalniProblemi\" ").FirstOrDefault();
            }




            if (rr == null)
                id = "1";
            else
            {
                id = rr["max"] != null ? rr["max"].ToString() : string.Empty;
                if (id == "")
                    id = "1";
                else
                {
                    int i = Convert.ToInt32(id);
                    i++;
                    id = i.ToString();
                }

            }

            return id;
        }

        #region Bolesti 

        public static List<Bolest> GetBolestiVrste(Vrsta vrsta)
        {
            ISession session = SessionManager.GetSession();
            List<Bolest> bolesti = new List<Bolest>();

            if (session == null)
                return null;

            var bolestiPodaci = session.Execute("select * from \"PotencijalniProblemi\" where \"vrstaID\"= '" + vrsta.vrstaID.ToString() + "'");

            foreach (var vrstaPodaci in bolestiPodaci)
            {
                Bolest bolest = new Bolest();
                bolest.bolestID = vrstaPodaci["problemID"] != null ? vrstaPodaci["problemID"].ToString() : string.Empty;
                bolest.vrstaId = vrstaPodaci["vrstaID"] != null ? vrstaPodaci["vrstaID"].ToString() : string.Empty;
                bolest.kolicinaVode = vrstaPodaci["kolicinavode"] != null ? Convert.ToDouble(vrstaPodaci["kolicinavode"]) : 0.0f;
                bolest.kolicinaHrane = vrstaPodaci["kolicinahrane"] != null ? Convert.ToDouble(vrstaPodaci["kolicinahrane"]) :0.0f;
                bolest.tezina = vrstaPodaci["tezina"] != null ? Convert.ToDouble(vrstaPodaci["tezina"]) : 0.0f;
                bolest.opis = vrstaPodaci["opis"] != null ? vrstaPodaci["opis"].ToString() : string.Empty;
                bolest.naziv = vrstaPodaci["nazivproblema"] != null ? vrstaPodaci["nazivproblema"].ToString() : string.Empty;

                bolesti.Add(bolest);
            }

            return bolesti;
        }

        public static void AddOrUpdateBolest(Bolest b)
        {
            ISession session = SessionManager.GetSession();

            if (session == null)
                return;


            String idToAdd;
            if (b.bolestID == null)//vrsi se dodavanje
            {
                idToAdd = getID(vrstazaID.Problem); /////
            }
            else
            {
                idToAdd = b.bolestID; //vrsi se azuriranje
            }

            RowSet guestData = session.Execute("insert into \"PotencijalniProblemi\" (\"problemID\", \"vrstaID\", kolicinavode, kolicinahrane, tezina, nazivproblema, opis) values" +
                "('" + idToAdd + "','" + b.vrstaId + "', " + b.kolicinaVode + ", " + b.kolicinaHrane + "," +
                "" + b.tezina + ",'" + b.naziv + "', '" + b.opis + "')");

        }

        public static void DeleteBolest(string bolestId, string vrstaId)
        {
            ISession session = SessionManager.GetSession();

            if (session == null)
                return;

            RowSet resultData = session.Execute("delete from \"PotencijalniProblemi\" where \"vrstaID\" = '" + vrstaId + "' and \"problemID\" = '" + bolestId + "'");
        }

        #endregion

        #region Zivotinja
        public static Zivotinja GetZivotinja(string zivotinjaID)
        {
            ISession session = SessionManager.GetSession();
            Zivotinja animal = new Zivotinja();

            if (session == null)
                return null;

            Row animalData = session.Execute("select * from \"Zivotinja\" where \"zivotinjaID\"='"+zivotinjaID+"'").FirstOrDefault();
                
            if (animalData != null)
            {
                animal.animalID = animalData["zivotinjaID"] != null ? animalData["zivotinjaID"].ToString() : string.Empty;
                animal.ime = animalData["ime"] != null ? animalData["ime"].ToString() : string.Empty;
                animal.pocetnaTezina = animalData["pocetnatezina"] != null ? animalData["pocetnatezina"].ToString() : string.Empty;
                animal.vrstaID = animalData["vrstaID"] != null ? animalData["vrstaID"].ToString() : string.Empty;
                animal.vlasnikID = animalData["vlasnikID"] != null ? animalData["vlasnikID"].ToString() : string.Empty;
            }

            return animal;
        }

        public static Zivotinja GetZivotinja(string zivotinjaID, string vlasnikID)
        {
            ISession session = SessionManager.GetSession();
            Zivotinja animal = new Zivotinja();

            if (session == null)
                return null;

            Row animalData = session.Execute("select * from \"Zivotinja\" where \"zivotinjaID\"='" + zivotinjaID + "' and \"vlasnikID\" = '"+vlasnikID+"'").FirstOrDefault();

            if (animalData != null)
            {
                animal.animalID = animalData["zivotinjaID"] != null ? animalData["zivotinjaID"].ToString() : string.Empty;
                animal.ime = animalData["ime"] != null ? animalData["ime"].ToString() : string.Empty;
                animal.pocetnaTezina = animalData["pocetnatezina"] != null ? animalData["pocetnatezina"].ToString() : string.Empty;
                animal.vrstaID = animalData["vrstaID"] != null ? animalData["vrstaID"].ToString() : string.Empty;
                animal.vlasnikID = animalData["vlasnikID"] != null ? animalData["vlasnikID"].ToString() : string.Empty;
            }

            return animal;
        }

        public static List<Zivotinja> GetZivotinje(String vlasnikID)
        {
            ISession session = SessionManager.GetSession();
            List<Zivotinja> animals = new List<Zivotinja>();


            if (session == null)
                return null;

            var Data = session.Execute("select * from \"Zivotinja\" where \"vlasnikID\" = '"+vlasnikID + "'");




            foreach (var animalData in Data)
            {
                Zivotinja hotel = new Zivotinja();
                hotel.animalID = animalData["zivotinjaID"] != null ? animalData["zivotinjaID"].ToString() : string.Empty;
                hotel.ime = animalData["ime"] != null ? animalData["ime"].ToString() : string.Empty;
                hotel.pocetnaTezina = animalData["pocetnatezina"] != null ? animalData["pocetnatezina"].ToString() : string.Empty;
                hotel.vlasnikID = animalData["vlasnikID"] != null ? animalData["vlasnikID"].ToString() : string.Empty;
                hotel.vrstaID = animalData["vrstaID"] != null ? animalData["vrstaID"].ToString() : string.Empty;

                animals.Add(hotel);
            }

            return animals;
        }

        public static List<Zivotinja> GetZivotinje()
        {
            ISession session = SessionManager.GetSession();
            List<Zivotinja> animals = new List<Zivotinja>();


            if (session == null)
                return null;

            var Data = session.Execute("select * from \"Zivotinja\"");


            

            foreach (var animalData in Data)
            {
                Zivotinja hotel = new Zivotinja();
                hotel.animalID = animalData["zivotinjaID"] != null ? animalData["zivotinjaID"].ToString() : string.Empty;
                hotel.ime = animalData["ime"] != null ? animalData["ime"].ToString() : string.Empty;
                hotel.pocetnaTezina = animalData["pocetnaTezina"] != null ? animalData["pocetnaTezina"].ToString() : string.Empty;
                hotel.vlasnikID = animalData["vlasnikID"] != null ? animalData["vlasnikID"].ToString() : string.Empty;
                hotel.vrstaID = animalData["vrstaID"] != null ? animalData["vrstaID"].ToString() : string.Empty;

                animals.Add(hotel);
            }

            return animals;
        }

        public static void AddAnimal(Zivotinja z)
        {
            ISession session = SessionManager.GetSession();

            if (session == null)
                return;


            String id = getID(vrstazaID.Zivotinja);
            RowSet Data = session.Execute("INSERT INTO \"Zivotinja\" (\"zivotinjaID\", ime, pocetnatezina, \"vlasnikID\", \"vrstaID\") "+
                                                                 "VALUES('"+getID(vrstazaID.Zivotinja) + "','" + z.ime + "','" + z.pocetnaTezina + "','" + z.vlasnikID + "','" + z.vrstaID +"' ) ");

        }

        #endregion

        #region Unos

        public static List<Unos> GetUnos(String zivotinjaID)
        {
            ISession session = SessionManager.GetSession();
            List<Unos> animals = new List<Unos>();


            if (session == null)
                return null;

            var Data = session.Execute("select * from \"Unos\" where \"zivotinjaID\" = '" + zivotinjaID + "'");




            foreach (var animalData in Data)
            {
                Unos hotel = new Unos();
                hotel.zivotinjaID = animalData["zivotinjaID"] != null ? animalData["zivotinjaID"].ToString() : string.Empty;
                hotel.dan = animalData["dan"] != null ? animalData["dan"].ToString() : string.Empty;
                hotel.mesec = animalData["mesec"] != null ? animalData["mesec"].ToString() : string.Empty;
                hotel.godina = animalData["godina"] != null ? animalData["godina"].ToString() : string.Empty;
                hotel.hrana = animalData["hrana"] != null ? Convert.ToDouble(animalData["hrana"]) : 0.0f;
                hotel.voda = animalData["voda"] != null ? Convert.ToDouble(animalData["voda"]) : 0.0;
                hotel.tezina = animalData["tezina"] != null ? Convert.ToDouble(animalData["tezina"]) : 0.0f;
                hotel.vreme = animalData["vreme"] != null ? Convert.ToInt32(animalData["vreme"]) : 0;
                animals.Add(hotel);
            }

            return animals;
        }

        public static List<Unos> GetPoslednjih30Unosa(String idzivotinje)
        {
            ISession session = SessionManager.GetSession();
            List<Unos> animals = new List<Unos>();
            
            if (session == null)
                return null;
            //staviti limit 30 posle u upitu, ovo radi probe
            var Data = session.Execute("select * from \"Unos\" where \"zivotinjaID\" = '" + idzivotinje + "' ORDER BY vreme, godina, mesec, dan ASC LIMIT 10");

            foreach (var animalData in Data)
            {
                Unos unos = new Unos();
                unos.zivotinjaID = animalData["zivotinjaID"] != null ? animalData["zivotinjaID"].ToString() : string.Empty;
                unos.dan = animalData["dan"] != null ? animalData["dan"].ToString() : string.Empty;
                unos.mesec = animalData["mesec"] != null ? animalData["mesec"].ToString() : string.Empty;
                unos.godina = animalData["godina"] != null ? animalData["godina"].ToString() : string.Empty;
                unos.hrana =  animalData["hrana"] != null ? Convert.ToDouble(animalData["hrana"]) : 0.0f;
                unos.voda = animalData["voda"] != null ? Convert.ToDouble(animalData["voda"]) : 0.0f;
                unos.tezina = animalData["tezina"] != null ? Convert.ToDouble(animalData["tezina"]) : 0.0f;
                unos.vreme = animalData["vreme"] != null ? Convert.ToInt32(animalData["vreme"]) : 0;

                animals.Add(unos);
            }

            return animals;
        }


        public static List<Unos> GetPoslednjih30Unosa(string idzivotinje, int vremeOd, int vremeDo)
        {
            ISession session = SessionManager.GetSession();
            List<Unos> animals = new List<Unos>();

            if (session == null)
                return null;
            //staviti limit 30 posle u upitu, ovo radi probe
            var Data = session.Execute("select * from \"Unos\" where \"zivotinjaID\" = '" + idzivotinje + "' and vreme > "+vremeOd + " and vreme < " + vremeDo + ";");

            foreach (var animalData in Data)
            {
                Unos unos = new Unos();
                unos.zivotinjaID = animalData["zivotinjaID"] != null ? animalData["zivotinjaID"].ToString() : string.Empty;
                unos.dan = animalData["dan"] != null ? animalData["dan"].ToString() : string.Empty;
                unos.mesec = animalData["mesec"] != null ? animalData["mesec"].ToString() : string.Empty;
                unos.godina = animalData["godina"] != null ? animalData["godina"].ToString() : string.Empty;
                unos.hrana = animalData["hrana"] != null ? Convert.ToDouble(animalData["hrana"]) : 0.0f;
                unos.voda = animalData["voda"] != null ? Convert.ToDouble(animalData["voda"]) : 0.0f;
                unos.tezina = animalData["tezina"] != null ? Convert.ToDouble(animalData["tezina"]) : 0.0f;
                unos.vreme = animalData["vreme"] != null ? Convert.ToInt32(animalData["vreme"]) : 0;

                animals.Add(unos);
            }

            return animals;
        }

        public static void AddUnos(Unos u)
        {
            ISession session = SessionManager.GetSession();

            if (session == null)
                return;

            int vremeee = 0;
            vremeee = Convert.ToInt32(u.godina) * 10000 + Convert.ToInt32( u.mesec) * 100 + Convert.ToInt32(u.dan);
            String id = getID(vrstazaID.Zivotinja);
            RowSet Data = session.Execute("INSERT INTO \"Unos\"(\"zivotinjaID\", vreme, dan, mesec, godina, hrana, tezina, voda)" +
                                                                 "VALUES('" + u.zivotinjaID + "',"  +vremeee + ", " + Convert.ToInt32( u.dan) + "," + Convert.ToInt32(u.mesec) + "," + Convert.ToInt32(u.godina) + "," + u.hrana + ","+ u.voda + "," + u.tezina + " ) ");

        }

        #endregion

        #region Vrsta

        public static Vrsta GetVrsta(string idvrste)
        {
            ISession session = SessionManager.GetSession();
            Vrsta vrsta = new Vrsta();

            if (session == null)
                return null;

            Row vrstaData = session.Execute("select * from \"Vrsta\" where \"vrstaID\"='" + idvrste + "'").FirstOrDefault();
             
            if (vrstaData != null)
            {
                vrsta.vrstaID = vrstaData["vrstaID"] != null ? vrstaData["vrstaID"].ToString() : string.Empty;
                vrsta.standardTezina = vrstaData["standardtezina"] != null ? vrstaData["standardtezina"].ToString() : string.Empty;
                vrsta.minimumTezina = vrstaData["minimumtezina"] != null ? vrstaData["minimumtezina"].ToString() : string.Empty;
                vrsta.maximumTezina = vrstaData["maximumtezina"] != null ? vrstaData["maximumtezina"].ToString() : string.Empty;

                vrsta.standardHrana = vrstaData["standardhrana"] != null ? vrstaData["standardhrana"].ToString() : string.Empty;
                vrsta.minimumHrana = vrstaData["minimumhrana"] != null ? vrstaData["minimumhrana"].ToString() : string.Empty;
                vrsta.maximumHrana = vrstaData["maximumhrana"] != null ? vrstaData["maximumhrana"].ToString() : string.Empty;

                vrsta.standardVoda = vrstaData["standardvoda"] != null ? vrstaData["standardvoda"].ToString() : string.Empty;
                vrsta.minimumVoda = vrstaData["minimumvoda"] != null ? vrstaData["minimumvoda"].ToString() : string.Empty;
                vrsta.maximumVoda = vrstaData["maximumvoda"] != null ? vrstaData["maximumvoda"].ToString() : string.Empty;

                vrsta.nazivvrste = vrstaData["nazivvrste"] != null ? vrstaData["nazivvrste"].ToString() : string.Empty;
                vrsta.opis = vrstaData["opis"] != null ? vrstaData["opis"].ToString() : string.Empty;
            }

            return vrsta;
        }

        public static List<Vrsta> GetVrste()
        {
            ISession session = SessionManager.GetSession();
            List<Vrsta> vrste = new List<Vrsta>();


            if (session == null)
                return null;

            var vrstePodaci = session.Execute("select * from \"Vrsta\"");


            foreach (var vrstaData in vrstePodaci)
            {
                Vrsta vrsta = new Vrsta();
                vrsta.vrstaID = vrstaData["vrstaID"] != null ? vrstaData["vrstaID"].ToString() : string.Empty;
                vrsta.standardTezina = vrstaData["standardtezina"] != null ? vrstaData["standardtezina"].ToString() : string.Empty;
                vrsta.minimumTezina = vrstaData["minimumtezina"] != null ? vrstaData["minimumtezina"].ToString() : string.Empty;
                vrsta.maximumTezina = vrstaData["maximumtezina"] != null ? vrstaData["maximumtezina"].ToString() : string.Empty;

                vrsta.standardHrana = vrstaData["standardhrana"] != null ? vrstaData["standardhrana"].ToString() : string.Empty;
                vrsta.minimumHrana = vrstaData["minimumhrana"] != null ? vrstaData["minimumhrana"].ToString() : string.Empty;
                vrsta.maximumHrana = vrstaData["maximumhrana"] != null ? vrstaData["maximumhrana"].ToString() : string.Empty;

                vrsta.standardVoda = vrstaData["standardvoda"] != null ? vrstaData["standardvoda"].ToString() : string.Empty;
                vrsta.minimumVoda = vrstaData["minimumvoda"] != null ? vrstaData["minimumvoda"].ToString() : string.Empty;
                vrsta.maximumVoda = vrstaData["maximumvoda"] != null ? vrstaData["maximumvoda"].ToString() : string.Empty;

                vrsta.nazivvrste = vrstaData["nazivvrste"] != null ? vrstaData["nazivvrste"].ToString() : string.Empty;
                vrsta.opis = vrstaData["opis"] != null ? vrstaData["opis"].ToString() : string.Empty;

                vrste.Add(vrsta);
            }

            return vrste;
        }

        //public static List<Guest> GetGuests()
        //{
        //    ISession session = SessionManager.GetSession();
        //    List<Guest> guests = new List<Guest>();

        //    if (session == null)
        //        return null;

        //    var guestsData = session.Execute("select * from \"Guest\"");


        //    foreach (var guestData in guestsData)
        //    {
        //        Guest guest = new Guest();
        //        guest.phone = guestData["phone"] != null ? guestData["phone"].ToString() : string.Empty;
        //        guest.email = guestData["email"] != null ? guestData["email"].ToString() : string.Empty;
        //        guest.fname = guestData["fname"] != null ? guestData["fname"].ToString() : string.Empty;
        //        guest.lname = guestData["lname"] != null ? guestData["lname"].ToString() : string.Empty;

        //        guests.Add(guest);
        //    }


        //    return guests;
        //}

        //public static void AddVrsta(Vrsta v)
        //{
        //    ISession session = SessionManager.GetSession();

        //    if (session == null)
        //        return;

            

        //    RowSet guestData = session.Execute("insert into \"Vrsta\"   (\"vrstaID\", nazivvrste, maximumhrana, maximumtezina, maximumvoda, minimumhrana, minimumtezina, minimumvoda, opis, standardhrana, standardtezina, standardvoda) values" +
        //        "('" + getID(vrstazaID.Vrsta) + "','" + v.nazivvrste + "','" + v.maximumHrana + "', '" + v.maximumTezina + "', '" + v.maximumVoda + "',"+
        //        "'" + v.minimumHrana + "','" + v.minimumTezina + "','" + v.minimumVoda + "', '" + v.opis + "'," +
        //        "'" + v.standardHrana + "','" + v.standardTezina + "','" + v.standardVoda + "')");

        //}

        public static void AddOrUpdateVrsta(Vrsta v)
        {
            ISession session = SessionManager.GetSession();

            if (session == null)
                return;


            String idToAdd;
            if (v.vrstaID == null)//vrsi se dodavanje
            {
                idToAdd = getID(vrstazaID.Vrsta); /////
            }
            else
            {
                idToAdd = v.vrstaID; //vrsi se azuriranje
            }

            RowSet guestData = session.Execute("insert into \"Vrsta\"   (\"vrstaID\", nazivvrste, maximumhrana, maximumtezina, maximumvoda, minimumhrana, minimumtezina, minimumvoda, opis, standardhrana, standardtezina, standardvoda) values" +
                "('" + idToAdd + "','" + v.nazivvrste + "','" + v.maximumHrana + "', '" + v.maximumTezina + "', '" + v.maximumVoda + "'," +
                "'" + v.minimumHrana + "','" + v.minimumTezina + "','" + v.minimumVoda + "', '" + v.opis + "'," +
                "'" + v.standardHrana + "','" + v.standardTezina + "','" + v.standardVoda + "')");

        }

        public static void DeleteVrsta(String idVr, String naziv)
        {
            ISession session = SessionManager.GetSession();

            if (session == null)
                return;

            RowSet guestData = session.Execute("delete from \"Vrsta\" where \"vrstaID\" = '" + idVr + "' and \"nazivvrste\" = '" + naziv + "'");
        }
        //public static void DeleteGuest(string phone)
        //{
        //    ISession session = SessionManager.GetSession();

        //    if (session == null)
        //        return;

        //    RowSet guestData = session.Execute("delete from \"Guest\" where phone = '" + phone + "'");

        //}

        #endregion

        #region Korisnik

        public static Korisnik GetKorisnik(string korisnikID)
        {
            ISession session = SessionManager.GetSession();
            Korisnik kor = new Korisnik();

            if (session == null)
                return null;

            Row data = session.Execute("select * from \"Korisnik\" where \"korisnikID\"='" + korisnikID + "'").FirstOrDefault();

            if (data != null)
            {
                kor.ime = data["ime"] != null ? data["ime"].ToString() : string.Empty;
                kor.prezime = data["prezime"] != null ? data["prezime"].ToString() : string.Empty;
                kor.korisnicko= data["korisnicko"] != null ? data["korisnicko"].ToString() : string.Empty;
                kor.lozinka = data["lozinka"] != null ? data["lozinka"].ToString() : string.Empty;
                kor.korisnikID = data["korisnikID"] != null ? data["korisnikID"].ToString() : string.Empty;
            }

            return kor;
        }

        public static Korisnik GetKorisnikPoKorImenu(string korisnicko)
        {
            ISession session = SessionManager.GetSession();
            Korisnik kor = null;

            if (session == null)
                return null;

            Row data = session.Execute("select * from \"Korisnik\" where \"korisnicko\"='" + korisnicko + "'").FirstOrDefault();

            if (data != null)
            {
                kor = new Korisnik();
                kor.ime = data["ime"] != null ? data["ime"].ToString() : string.Empty;
                kor.prezime = data["prezime"] != null ? data["prezime"].ToString() : string.Empty;
                kor.korisnicko = data["korisnicko"] != null ? data["korisnicko"].ToString() : string.Empty;
                kor.lozinka = data["lozinka"] != null ? data["lozinka"].ToString() : string.Empty;
                kor.korisnikID = data["korisnikID"] != null ? data["korisnikID"].ToString() : string.Empty;
            }

            return kor;
        }

        public static Korisnik UserExists(String korIme,String pass)
        {
            Korisnik k = GetKorisnikPoKorImenu(korIme);
            if (k != null && k.lozinka.Equals(pass))
                return k;
            else
                return null;
        }

        //public static List<Reservation> GetReservations()
        //{
        //    ISession session = SessionManager.GetSession();
        //    List<Reservation> reservations = new List<Reservation>();

        //    if (session == null)
        //        return null;

        //    var reservationsData = session.Execute("select * from \"Reservation\"");


        //    foreach (Row reservationData in reservationsData)
        //    {
        //        Reservation reservation = new Reservation();
        //        reservation.hotelID = reservationData["hotelID"] != null ? reservationData["hotelID"].ToString() : string.Empty;
        //        reservation.roomID = reservationData["roomID"] != null ? reservationData["roomID"].ToString() : string.Empty;
        //        reservation.resID = reservationData["resID"] != null ? reservationData["resID"].ToString() : string.Empty;
        //        reservation.arrive = reservationData["arrive"] != null ? reservationData["arrive"].ToString() : string.Empty;
        //        reservation.depart = reservationData["depart"] != null ? reservationData["depart"].ToString() : string.Empty;
        //        reservation.name = reservationData["name"] != null ? reservationData["name"].ToString() : string.Empty;
        //        reservation.phone = reservationData["phone"] != null ? reservationData["phone"].ToString() : string.Empty;
        //        reservation.rate = reservationData["rate"] != null ? reservationData["rate"].ToString() : string.Empty;

        //        reservations.Add(reservation);
        //    }


        //    return reservations;
        //}

        public static void AddKorisnik(Korisnik k)
        {
            ISession session = SessionManager.GetSession();

            if (session == null)
                return;

            RowSet data = 
                session.Execute("INSERT INTO \"Korisnik\"(\"korisnikID\", ime, korisnicko, lozinka, prezime)"+
                                  "VALUES('"+getID(vrstazaID.Korisnik)+"','" + k.ime +"','" + k.korisnicko + "','" + k.lozinka +  "','" + k.prezime + "');");

        }

        //public static void DeleteReservation(string resID)
        //{
        //    ISession session = SessionManager.GetSession();

        //    if (session == null)
        //        return;

        //    RowSet reservationData = session.Execute("delete from \"Reservation\" where \"resID\" = '" + resID + "'");

        //}

        #endregion

    }
}
