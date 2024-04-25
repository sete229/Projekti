using System.ComponentModel.DataAnnotations;
using System.Net;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;


Console.WriteLine("GOLDS GYM NIKOLA MARINOVIĆ");



string logoputanja = "C:\\Users\\korisnik\\Desktop\\logo.txt";
bool logoprikazan = false;
if (!logoprikazan)
{ 
    Asciprinter.Printasciiart(logoputanja);
    logoprikazan = true;
}

string putdodatoteke = "C:\\Users\\korisnik\\Desktop\\korisnici.txt";
List<Korisnik> nizkorisnika = Ucitajkorisnike(putdodatoteke);

string putdofajla = "C:\\Users\\korisnik\\Desktop\\sprave.txt";
List<sprave> nizsprava = Ucitajsprave(putdofajla);

string putic = "C:\\Users\\korisnik\\Desktop\\treneri.txt";
List<Trener> niztrenera = Ucitajtrenere(putic);

string path = "C:\\Users\\korisnik\\Desktop\\trening.txt";
List<trening> niztreninga = Ucitajtreninge(path);

while (true)
{
Console.WriteLine("Glavni izbornik:");
Console.WriteLine("1. Ispis iz datoteka");
Console.WriteLine("2. unos u datoteke");
Console.WriteLine("3.brisanje iz datoteka");
Console.WriteLine("4.spremanje u datoteke ");
Console.WriteLine("5.izbornik za statistiku");
Console.WriteLine("6. kraj");

int Unos = Convert.ToInt32(Console.ReadLine());
switch (Unos)
{
case 1:
Podizbornikzaispis();
break;
case 2:
Podizbornikzaunos();
break;
case 3:
podizbornikzabrisanje();
break;
case 4:
Podizbornikzaspremanje();
break;
case 5:
 Podizbornikzastatistiku();
 break;
case 6:
return;

default:
Console.WriteLine("neispravan unos");
break;
}
}




void Podizbornikzaspremanje()
    {
        while (true)
        {
            Console.WriteLine("PODIZBORNIK ZA SPREMANJE");
            Console.WriteLine("1.spremi korisnika u fajl");
            Console.WriteLine("2.spremi sprave u fajl");
            Console.WriteLine("3.spremi trenera u fajl");
            Console.WriteLine("4.spremi trening u fajl");
            Console.WriteLine("5. povratak na glavni izbornik");

            int unos = Convert.ToInt32(Console.ReadLine());
            switch (unos)
            {
                case 1:
                    Spremikorisnikeufajl(putdodatoteke, nizkorisnika);
                    break;
                case 2:
                    Spremispraveufajl(putdofajla, nizsprava);
                    break;
                case 3:
                    Spremitreneraufajl(putic, niztrenera);
                    break;
                case 4:
                    Spremitreningufajl(path, niztreninga);
                    break;
                case 5:
                    return;
                    break;
                default:
                    Console.WriteLine("pogresan unos");
                    break;
            }
        }

    }
void podizbornikzabrisanje()
    {
        while (true)
        {
            Console.WriteLine("PODIZBORNIK ZA  BRISANJE");
            Console.WriteLine("1.izbrisi korisnika");
            Console.WriteLine("2.izbrisi sprave");
            Console.WriteLine("3.izbrisi trenera");
            Console.WriteLine("4.izbrisi trening");
            Console.WriteLine("5.povratak na glavni izbornik");

            int unos = Convert.ToInt32(Console.ReadLine());

            switch (unos)
            {
                case 1:
                    Izbrisikorisnika(nizkorisnika);
                    break;
                case 2:
                    Izbrisisprave(nizsprava);
                    break;
                case 3:
                    Izbrisitrenera(niztrenera);
                    break;
                case 4:
                    Izbrisitrening(niztreninga);
                    break;
                case 5:
                    return;
                    break;
                default:
                    Console.WriteLine("pogresan unos");
                    break;
            }

        }

    }
void Podizbornikzaispis()
    {
        while (true)
        {
            Console.WriteLine("PODIZBORNIK ZA ispis");
            Console.WriteLine("1.ispis korisnika \n" +
                "2.ispis sprava \n" +
                "3ispis trenera\n" +
                "4.ispis treninga \n" +
                "5.povratak na glavni izbornik \n");


            int unos = Convert.ToInt32(Console.ReadLine());
            switch (unos)
            {
                case 1:
                    Ispisikorisnike(nizkorisnika);
                    break;

                case 2:
                    Ispisisprave(nizsprava);
                    break;
                case 3:
                    Ispisitrenere(niztrenera);
                    break;
                case 4:
                    Ispisitreninge(niztreninga);
                    break;
                case 5:
                    return;
                    break;
                default:
                    Console.WriteLine("neispravan unos");
                    break;
            }

        }
    }
void Podizbornikzaunos()
    {
        while (true)
        {
            Console.WriteLine("PODIZBORNIK ZA UNOS");
            Console.WriteLine("1.unos korisnika \n" +
                "2.unos sprava \n" +
                "3.unos trenera\n" +
                "4.unos treninga \n" +
                "5.povratak na glavni izbornik \n");

            int unos = Convert.ToInt32(Console.ReadLine());
            switch (unos)
            {
                case 1:
                    nizkorisnika.Add(Unesinovogkorisnika());
                    break;

                case 2:
                    nizsprava.Add(Unesinovuspravu());
                    break;

                case 3:
                    niztrenera.Add(Unesinovogtrenera());
                    break;
                case 4:
                    niztreninga.Add(Unesinovitrening());
                    break;
                case 5:
                    return;
                    break;

                default:
                    Console.WriteLine("neispravan unos");
                    break;

            }
        }
    }
void Podizbornikzastatistiku() 
{ 
    while (true) 
    {
        Console.WriteLine("PODIZBORNIK ZA STATISTIKU");
        Console.WriteLine("1.Trener s najvecom placom");
        Console.WriteLine("2.korisnik s najvecom clanarinom");
        Console.WriteLine("3.najvise izabran trening");
        Console.WriteLine("4.najskuplji trening");
        Console.WriteLine("5.najskuplja sprava je");
        Console.WriteLine("6.povratak na glavni izbornik");

        int unos = Convert.ToInt32(Console.ReadLine());
        switch (unos)
        {
            case 1:
                Placatrenera(niztrenera);
                break;
                case 2:
                Korisniksanajvecunclanarinom(nizkorisnika);
                break;
                case 3:
                NajviseIzabranTrening(niztreninga);
                break;
                case 4:
                Najskupljitrening(niztreninga);
                break;
                case 5:
                Najskupljasprava(nizsprava);
                break;
            case 6:
                return;
                break;
                default: Console.WriteLine("pogreska");
                break;
        }

    
    }
}

void NajviseIzabranTrening(List<trening> niztreninga)
    {
        if (niztreninga.Count == 0)
        {
            Console.WriteLine("Nema treninga za prikaz popunjenosti.");
            return;
        }

        trening najizabranijitrening = niztreninga[0];

        foreach (trening trening in niztreninga)
        {
            if (trening.popunjenost > najizabranijitrening.popunjenost)
            {
                najizabranijitrening = trening;
           
            }
        }

        Console.WriteLine("Najviše izabran trening: {0}", najizabranijitrening.ToString());
    }
void Najskupljitrening(List<trening> niztreninga)
    {
        if (niztreninga.Count == 0)
        {
            Console.WriteLine("nema trenninga");
            return;
        }
        trening treninignajskuplji = niztreninga[0];

        foreach (trening trening in niztreninga)
        {
            if (trening.cijena > treninignajskuplji.cijena)
            {
                treninignajskuplji = trening;
             

            }


        }
        Console.WriteLine("najskuplji trening je {0}", treninignajskuplji.ToString());
    }
void Placatrenera(List<Trener> niztrenera)
    {
        if (niztrenera.Count == 0)
        {
            Console.WriteLine("placa se nemoze prikazat");
            return;

        }
        Trener trenersnajvecunplacun = niztrenera[0];

        foreach (Trener trener in niztrenera)
        {
            if (trener.placa > trenersnajvecunplacun.placa)
            {
                trenersnajvecunplacun = trener;

            }

        }
        Console.WriteLine("trener s najvecun placun je {0} ", trenersnajvecunplacun.ToString());
    }
void Ispisitreninge(List<trening> treninzi)
    {
        foreach (trening trening in treninzi)
        {
            Console.WriteLine(trening.ToString());
        }

    }
void Izbrisitrening(List<trening> niztreninga)
    {
        Console.WriteLine("upisite id treninga kojeg zelite izbrisati");
        int idtreninga = Convert.ToInt32(Console.ReadLine());

        foreach (trening trening in niztreninga)
        {
            if (idtreninga == trening.idtreninga)
            {
                Console.WriteLine("nasao sam trening i sada ga micem");
                niztreninga.Remove(trening);
                return;
            }
        }
    }
void Spremitreningufajl(string path, List<trening> niztreninga)
    {
        List<string> linijazaupis = new List<string>();
        foreach (trening trening in niztreninga)
        {
            string linija = string.Format("{0};{1};{2};{3};{4};{5};", trening.idtreninga, trening.imetreninga, trening.popunjenost, trening.dodijeljenitrener, trening.cijena, trening.korisniktreninga);
            linijazaupis.Add(linija);
        }
        File.WriteAllLines(path, linijazaupis);
    }
trening Unesinovitrening()
    {
        Console.WriteLine("generiram random id treninga");
        int randomId = Generirajidtreninga();
        Console.WriteLine("unesite ime treninga");
        string imetreninga = Console.ReadLine();
        Console.WriteLine("unesite koliko je ostalo mjesta na treningu");
        int popunjenost = int.Parse(Console.ReadLine());
        Console.WriteLine("uneiste id dodijeljnog trenera");
        string dodijeljenitrener = Console.ReadLine();
        Console.WriteLine("uneiste cijenu treninga iz fajla");
        float cijenatreninga = float.Parse(Console.ReadLine());
        Console.WriteLine("unesite id korisnika");
        int korisniktreninga = int.Parse(Console.ReadLine());


        return new trening(randomId, imetreninga, popunjenost, dodijeljenitrener, cijenatreninga, korisniktreninga);

    }
static int Generirajidtreninga()
    {
        Random random = new Random();
        return random.Next(0, 9000);
    }
List<trening> Ucitajtreninge(string path)
    {
        List<trening> trening = new List<trening>();

        foreach (string linija in File.ReadAllLines(path))
        {
            string[] dilovi = linija.Split(";");

            trening.Add(new trening(int.Parse(dilovi[0]), dilovi[1], int.Parse(dilovi[2]), dilovi[3], float.Parse(dilovi[4]), int.Parse(dilovi[5])));
        }

        return trening;
    }

void Izbrisitrenera(List<Trener> niztrera)
    {
        Console.WriteLine("upisite id trenera kojeg zelite izbrisat");
        int idtrenera = Convert.ToInt32(Console.ReadLine());

        foreach (Trener trener in niztrenera)
        {
            if (trener.idtrenera == idtrenera)
            {
                Console.WriteLine("brisem trenera");
                niztrenera.Remove(trener);
                return;
            }

        }
    }
void Spremitreneraufajl(string putic, List<Trener> niztrenera)
    {
        List<string> linijazaupis = new List<string>();
        foreach (Trener trener in niztrenera)
        {
            string linija = string.Format("{0};{1};{2};{3}", trener.imetrenera, trener.idtrenera, trener.placa, trener.specijalitettrenera);
            linijazaupis.Add(linija);
        }
        File.WriteAllLines(putic, linijazaupis);
    }
void Ispisitrenere(List<Trener> treneri)
    {
        foreach (Trener trener in treneri)
        {
            Console.WriteLine(trener.ToString());
        }

    }
Trener Unesinovogtrenera()
    {
        Console.WriteLine("unesite ime trenera");
        string imetrenera = Console.ReadLine();
        Console.WriteLine("generiram id trenera");
        int randomId = generirajidtrenera();
        Console.WriteLine("unesite placu trenera");
        float placa = float.Parse(Console.ReadLine());
        Console.WriteLine("unesite specijalitet trenera");
        string specijalitettrenera = Console.ReadLine();

        return new Trener(imetrenera, randomId, placa, specijalitettrenera);

    }
static int generirajidtrenera()
    {
        Random random = new Random();
        return random.Next(1000, 9000);

    }
List<Trener> Ucitajtrenere(string putic)
    {
        List<Trener> trener = new List<Trener>();
        foreach (string linija in File.ReadAllLines(putic))
        {
            string[] dilovi = linija.Split(";");
            trener.Add(new Trener(dilovi[0], int.Parse(dilovi[1]), float.Parse(dilovi[2]), dilovi[3]));
        }
        return trener;
    }

void Najskupljasprava(List<sprave> nizsprava) 
{
    if (nizsprava.Count == 0) 
    {
        Console.WriteLine("ne postoje sprave");
        return;
    
    }
    sprave spravanajskuplja = nizsprava[0];

    foreach (sprave sprave in nizsprava)
    {
        if (sprave.cijenasprave > spravanajskuplja.cijenasprave)
        {
            spravanajskuplja = sprave;
        }
    
    }
    Console.WriteLine("Najskuplja sprava je {0}", spravanajskuplja.ToString());

}
void Izbrisisprave(List<sprave> nizsprava)
    {
        Console.WriteLine("unesite id sprave koju zelite izbrisati");
        int idsprave = Convert.ToInt32(Console.ReadLine());

        foreach (sprave sprave in nizsprava)
        {
            if (sprave.idsprave == idsprave)
            {
                Console.WriteLine("nasao sam spravu i sada je brisem");
                nizsprava.Remove(sprave);
                return;
            }
        }

    }
void Spremispraveufajl(string putdofajla, List<sprave> nizsprava)
    {
        List<string> linijazaupis = new List<string>();
        foreach (sprave sprave in nizsprava)
        {
            string linija = string.Format("{0};{1};{2};{3}", sprave.imesprave, sprave.idsprave, sprave.namjenasprave, sprave.cijenasprave);
            linijazaupis.Add(linija);
        }
        File.WriteAllLines(putdofajla, linijazaupis);
    }
void Ispisisprave(List<sprave> sprava)
    {
        foreach (sprave sprave in sprava)
        {
            Console.WriteLine(sprave.ToString());

        }

    }
sprave Unesinovuspravu()
    {
        Console.WriteLine("unesite ime sprave");
        string imesprave = Console.ReadLine();
        Console.WriteLine("generiram id za spravu");
        int RandomId = Generirajidzasprave();
        Console.WriteLine("koja je namjena sprave");
        string namjenasprave = Console.ReadLine();
        Console.WriteLine("kolika je cijena sprave");
        float cijenasprave = float.Parse(Console.ReadLine());

        return new sprave(imesprave, RandomId, namjenasprave, cijenasprave);

    }
static int Generirajidzasprave()
    {
        Random random = new Random();
        return random.Next(1000, 9999);
    }
List<sprave> Ucitajsprave(string putdofajla)
    {
        List<sprave> sprave = new List<sprave>();
        foreach (string linija in File.ReadAllLines(putdofajla))
        {
            string[] dilovi = linija.Split(";");
            sprave.Add(new sprave(dilovi[0], int.Parse(dilovi[1]), dilovi[2], float.Parse(dilovi[3])));

        }
        return sprave;


    }

void Korisniksanajvecunclanarinom(List<Korisnik> nizkorisnika)
    {
        if (nizkorisnika.Count == 0)
        {
            Console.WriteLine("nema korisnika");
            return;
        }

        Korisnik korisnikkojiimanajvecuclanarinu = nizkorisnika[0];

        foreach (Korisnik korisnik in nizkorisnika)
        {
            if (korisnik.clanarina > korisnikkojiimanajvecuclanarinu.clanarina)
            {

                korisnikkojiimanajvecuclanarinu = korisnik;
              

            }


        }
        Console.WriteLine("korisnik koji najvise placa clanarinu je {0}", korisnikkojiimanajvecuclanarinu.ToString());
    }
void Izbrisikorisnika(List<Korisnik> nizkorisnika)
    {
        Console.WriteLine("unesite id korisnika kojeg zelite izbrisati");
        int korisnikid = Convert.ToInt32(Console.ReadLine());

        foreach (Korisnik korisnik in nizkorisnika)
        {
            if (korisnik.id == korisnikid)
            {
                Console.WriteLine("pronasao sam korisnika i sada ga brisem {0}", korisnik.ToString());
                nizkorisnika.Remove(korisnik);
                return;

            }
        }

    }
void Spremikorisnikeufajl(string putdodatoteke, List<Korisnik> nizkorisnika)
    {
        List<string> linijazaupis = new List<string>();
        foreach (Korisnik korisnik in nizkorisnika)
        {
            string linija = string.Format("{0};{1};{2};", korisnik.imeprezime, korisnik.clanarina, korisnik.id);
            linijazaupis.Add(linija);
        }
        File.WriteAllLines(putdodatoteke, linijazaupis);


    }
void Ispisikorisnike(List<Korisnik> korisnici)
    {
        foreach (Korisnik korisnik in korisnici)
        {
            Console.WriteLine(korisnik.ToString());

        }
    }
Korisnik Unesinovogkorisnika()
    {
        Console.WriteLine("unesite ime i prezime korisnika");
        string imeprezime = Console.ReadLine();
        Console.WriteLine("unesite cijenu članarine");
        double clanarina = double.Parse(Console.ReadLine());
        Console.WriteLine("generiram random id");

        int randomId = GenerirajrandomId();

        return new Korisnik(imeprezime, clanarina, randomId);


    }
static int GenerirajrandomId()
    {
        Random random = new Random();
        return random.Next(1000, 9999);

    }
List<Korisnik> Ucitajkorisnike(string putdodatoteke)
    {
        List<Korisnik> korisnik = new List<Korisnik>();
        foreach (string linija in File.ReadAllLines(putdodatoteke))
        {
            string[] dilovi = linija.Split(";");
            korisnik.Add(new Korisnik(dilovi[0], double.Parse(dilovi[1]), int.Parse(dilovi[2])));
        }
        return korisnik;
    }


public class trening
{
    public int idtreninga;
    public string imetreninga;
    public int popunjenost;
    public string dodijeljenitrener;
    public float cijena;
    public int korisniktreninga;

    public trening(int idtreninga, string imetreninga, int popunjenost, string dodijeljenitrener, float cijena, int korisniktreninga)
    {
        this.idtreninga = idtreninga;
        this.imetreninga = imetreninga;
        this.popunjenost = popunjenost;
        this.dodijeljenitrener = dodijeljenitrener;
        this.cijena = cijena;
        this.korisniktreninga = korisniktreninga;
    }
    public string ToString()
    {
        return string.Format("id treninga {0},ime treninga{1} popunjenost {2},dodijeljeni trener {3},cijena {4}, korisnik {5}", idtreninga, imetreninga, popunjenost, dodijeljenitrener, cijena, korisniktreninga);

    }


}
public class Trener
{
    public string imetrenera;
    public int idtrenera;
    public float placa;
    public string specijalitettrenera;

    public Trener(string imetrenera, int idtrenera, float placa, string specijalitettrenera)
    {
        this.imetrenera = imetrenera;
        this.idtrenera = idtrenera;
        this.placa = placa;
        this.specijalitettrenera = specijalitettrenera;
    }
    public string ToString()
    {
        return string.Format("ime trenera {0},idtrenera {1},placa trenera {2}, specijalitet trenera {3}", imetrenera, idtrenera, placa, specijalitettrenera);


    }

}
public class sprave
{
    public string imesprave;
    public int idsprave;
    public string namjenasprave;
    public float cijenasprave;

    public sprave(string imesprave, int idsprave, string namjenasprave, float cijenasprave)
    {
        this.imesprave = imesprave;
        this.idsprave = idsprave;
        this.namjenasprave = namjenasprave;
        this.cijenasprave = cijenasprave;
    }
    public string ToString()
    {
        return string.Format("ime sprave {0},id sprave {1},namjena sprave {2},cijena sprave {3}", imesprave, idsprave, namjenasprave, cijenasprave);
    }
}
public class Korisnik
{
    public string imeprezime;
    public double clanarina;
    public int id;

    public Korisnik(string imeprezime, double clanarina, int id)
    {
        this.imeprezime = imeprezime;
        this.clanarina = clanarina;
        this.id = id;
    }
    public string ToString()
    {
        return string.Format("Ime I prezime {0},clanarina {1},id {2}", imeprezime, clanarina, id);
    }

}
public class Asciprinter
{
    public static void Printasciiart(string loguputanja)
    {
        string asciiart = File.ReadAllText(loguputanja);
        Console.WriteLine(asciiart);
    }

}