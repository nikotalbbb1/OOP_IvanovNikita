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
        õpetaja.Õpeta();
        õpetaja.Kirjelda();

        Õpilane õpilane = new Õpilane();
        õpilane.Nimi = "Nikita";
        õpilane.Sünniaasta = 2009;
        õpilane.Kool = "Kool";
        õpilane.Klass = 10;
        õpilane.Õpi();
        õpilane.Kirjelda();
    }
}