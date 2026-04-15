using OOP_IvanovNikita;

public class Start()
{
    public static void Main(string[] args)
    {
        //Isik inimene1 = new Isik();
        Isik inimene1 = new Õpilane();
        inimene1.Nimi = "Mati";
        inimene1.Sünniaasta = 2000;
        inimene1.Tervita();
        

        Õpetaja õpetaja = new Õpetaja();
        õpetaja.Nimi = "Nimi";
        õpetaja.Aine = "Matemaatika";
        õpetaja.Sünniaasta = 1980;
        õpetaja.Tunnidkuus = 20;
        õpetaja.Tunnitasu = 7;
        õpetaja.Õpeta();
        õpetaja.Kirjelda();
        õpetaja.ArvutaPalk();

        Õpilane õpilane = new Õpilane();
        õpilane.Nimi = "Nikita";
        õpilane.Sünniaasta = 2009;
        õpilane.Kool = "Kool";
        õpilane.Klass = 10;
        õpilane.Puudumised = 30;
        õpilane.KeskmineHinne = 3.9;
        õpilane.KasOnSotsTõend = false;
        õpilane.Staatus = Õppevorm.Päevane;
        Console.WriteLine($"Summa: {õpilane.ArvutaPalk()}");

        õpilane.Õpi();

        õpilane.Kirjelda();

        List<ITööline> palgasaajad = new List<ITööline>();

        Random rnd = new Random();
        string[] nimed = { "Maria", "Siim", "Anna", "Juhan", "Kati" };
        Õppevorm[] vormid = (Õppevorm[])Enum.GetValues(typeof(Õppevorm));
        for (int i = 0; i < nimed.Length; i++)
        {

            Õpilane õpilane1 = new Õpilane
            {
                Nimi = nimed[rnd.Next(nimed.Length)],
                Klass = rnd.Next(1, 13),
                Kool = "TTHK",
                KeskmineHinne = rnd.NextDouble() * 5,
                Puudumised = rnd.Next(0, 100),
                KasOnSotsTõend = rnd.Next(0, 2) == 1,
                Staatus = vormid[rnd.Next(vormid.Length)]

            };
            palgasaajad.Add(õpilane1);

        }
        Console.WriteLine("----Väljamaksed---");
        foreach (ITööline isik in palgasaajad)
        {
            //string tüüp = isik.Tüüp.ToString();
            Console.WriteLine($"Väljamakse summa: {isik.ArvutaPalk()} eurot. {((Isik)isik).Nimi}le");
        }


        Koolihaldus minuKool = new Koolihaldus();

        Õpetaja op = new Õpetaja { Nimi = "Mati", Aine = "Programmeerimine" };
        Õpetaja op2 = new Õpetaja { Nimi = "Kati", Aine = "Programmeerimine" };
        Õpilane opilane1 = new Õpilane { Nimi = "Mari", Klass = 10, Staatus = Õppevorm.Päevane };
        Õpilane opilane2 = new Õpilane { Nimi = "Juri", Klass = 11, Staatus = Õppevorm.Kaugõpe };
        Õpilane opilane3 = new Õpilane { Nimi = "Kati", Klass = 10, Staatus = Õppevorm.Ekstern };
        Õpilane opilane5 = new Õpilane { Nimi = "Juhan", Klass = 12, Staatus = Õppevorm.AkadeemilinePuhkus };
        Õpilane opilane4= new Õpilane { Nimi = "Anna", Klass = 10, Staatus = Õppevorm.Päevane };

        minuKool.LisaInimene(op);
        minuKool.LisaInimene(op2);
        minuKool.LisaInimene(opilane1);
        minuKool.LisaInimene(opilane2);
        minuKool.LisaInimene(opilane3);
        minuKool.LisaInimene(opilane4);
        minuKool.LisaInimene(opilane5);

        minuKool.KuvaKõik();
    }
}