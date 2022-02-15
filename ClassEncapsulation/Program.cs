Ogrenciler ogrenci=new Ogrenciler();
ogrenci.Isim="Ögrenci-ad-1";
ogrenci.Soyad="Ögrenci-soyad-1";
ogrenci.No=5;
ogrenci.Sinif=1;
ogrenci.OgrenciBilgileriniGetir();
Console.WriteLine(Ogrenciler.Ogrenci_sayi);
Console.ReadKey();
class Ogrenciler{
    private static int ogrenci_sayi;
    private string isim;
    private string soyad;
    private int no;
    private int sinif;
    public Ogrenciler(string isim, string soyad, int no, int sinif) 
    {
        this.isim = isim;
        this.soyad = soyad;
        this.no = no;
        this.sinif = sinif;
        
    }
    static Ogrenciler()
    {
        Ogrenci_sayi=0;
    }
    public Ogrenciler()
    {

    }
    public void OgrenciBilgileriniGetir()
    {
        Console.WriteLine(this.isim);
        Console.WriteLine(this.soyad);
        Console.WriteLine(this.no);
        Console.WriteLine(this.sinif);
        Ogrenci_sayi++;
    }
    public string Isim
    {
        get{return isim; }
        set{ isim=value;}
    }

    public string Soyad { get => soyad; set => soyad = value; }
    public int No { get => no; set => no = value; }
    public int Sinif { get => sinif; set => sinif = value; }
    public static int Ogrenci_sayi { get => ogrenci_sayi; set => ogrenci_sayi = value; }
}
