 class Program
{
    static void Main(String[] args)
    {
      Kurs kurs1 = new Kurs();
        kurs1.KursAdi = "C#";
        kurs1.Egitmen = "Emre";
        kurs1.izlenmeOrani = 70;

      Kurs kurs2 = new Kurs();
        kurs2.KursAdi = "Java";
        kurs2.Egitmen = "Omer";
        kurs2.izlenmeOrani = 80;

      Kurs kurs3 = new Kurs();
        kurs3.KursAdi = "Python";
        kurs3.Egitmen = "Yidiz";
        kurs3.izlenmeOrani = 90;

        // Console.WriteLine("Kurslarımız : "+ kurs1.KursAdi + ", " + kurs2.KursAdi + ", " + kurs3.KursAdi);

        Kurs[] kurslar = new Kurs[] { kurs1, kurs2, kurs3 };
        Console.WriteLine("Kurslarımız: ");
        foreach (Kurs kurs in kurslar)
        {
            Console.WriteLine("Kurs Adı: " + kurs.KursAdi + "/ Eğitmen: " + kurs.Egitmen + " /İzlenme Oranı: " + kurs.izlenmeOrani);
        }
    }

}
class Kurs
{
    public string KursAdi { get; set; }

    public string Egitmen { get; set; }

    public int izlenmeOrani  { get; set; }

}

