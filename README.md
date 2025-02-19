# AnimTracker
.NET Forms application intended for zookeepers to keep track of their animals

The application uses Cassandra as a persistence layer. The database has tables for an animal (Zivotinja), its species (Vrsta), an update on their state (Unos), its potential problems - risks (PotencijalniProblemi) and zookeepers (Korisnik).
 Every species has a standard, minimum and maximum of its weight, food and water intake, while every animal has its species, as well as an owner and weight. Zookeepers are responsible for updating their animals' states by listing the amount of food and water they fed the animal, along 
 with the current time and the animal's weight. Potential problems are added by the admin (as well as species), listing their weight, current food and water intake when they have that problem and the problem description.
 There is also a page where the statistics of an animal's water and food intake and weight through time can be displayed in different graph forms.

 The SQL commands used for creating the aforementioned tables are listed below:

 ```
CREATE TABLE "Unos" (
    hrana float,
    voda float,
    tezina float,
    dan int,
    mesec int,
    godina int,
    vreme timestamp,
    "zivotinjaID" text,
    PRIMARY KEY ( "zivotinjaID", godina,mesec,dan)
);

CREATE TABLE "Vrsta" (
    "vrstaID" text,
    nazivvrste text,
    standardTezina float,
    minimumTezina float,
    maximumTezina float,
    standardHrana float,
    minimumHrana float,
    maximumHrana float,
    standardVoda float,
    minimumVoda float,
    maximumVoda float,
    opis text,
    PRIMARY KEY ("vrstaID", nazivvrste)
);


CREATE TABLE "Zivotinja" (
    "zivotinjaID" text,
    pocetnaTezina text,
    ime text,
    "vrstaID" text,
    "vlasnikID" text,
    PRIMARY KEY ( "vlasnikID" ,"zivotinjaID")
);


CREATE TABLE "Korisnik" (
    "korisnikID" text,
    ime text,
    prezime text,
    korisnicko text,
    lozinka text,
    PRIMARY KEY (korisnicko,"korisnikID" )
);


CREATE TABLE "PotencijalniProblemi" (
    "problemID" text,
    nazivProblema text,
    kolicinaVode float,
    kolicinaHrane float,
    tezina float,
    opis text,
    "vrstaID" text,
    PRIMARY KEY ("vrstaID", "problemID")
);
```
