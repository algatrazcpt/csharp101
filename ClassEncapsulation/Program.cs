Ogrenciler ogrenci=new Ogrenciler();
ogrenci.Isim="Ögrenci-ad-1";
ogrenci.Soyad="Ögrenci-soyad-1";
ogrenci.No=5;
ogrenci.Sinif=1;
ogrenci.OgrenciBilgileriniGetir();
Console.ReadKey();
class Ogrenciler{
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
    public Ogrenciler()
    {

    }
    public void OgrenciBilgileriniGetir()
    {
        Console.WriteLine(this.isim);
        Console.WriteLine(this.soyad);
        Console.WriteLine(this.no);
        Console.WriteLine(this.sinif);
    }
    public string Isim
    {
        get{return isim; }
        set{ isim=value;}
    }

    public string Soyad { get => soyad; set => soyad = value; }
    public int No { get => no; set => no = value; }
    public int Sinif { get => sinif; set => sinif = value; }
}
