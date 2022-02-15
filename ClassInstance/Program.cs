Console.WriteLine("Class İnstance");

/*
1. Public : Her yerden erişilebilir.

2. Private : Sadece tanımlandığı sınıf içerisinden erişilebilir.

3. Internal : Sadece bulunduğu proje içerisinden erişilebilir

4. Protected : Sadece tanımlandığı sınıfta ya da o sınıfı miras alan sınıflardan erişilebilir.


class SinifAdi
{
    [Erişim Belirleyici][Veri Tipi] ÖzellikAdı;
    [Erişim Belirleyici][Geri Dönüş Değerinin Tipi] MetotAdi([Parametreler])
    {
        //Metot Gövdesi
    }
}


*/
Kullanici kullanici1=new Kullanici();
kullanici1.kullanici_ad="Kullanici 1";
kullanici1.kullanici_id=1;
kullanici1.BilgileriYazdir();
Console.ReadKey();

class Kullanici
{
    public string kullanici_ad;
    private string kullanici_parola;
    public int kullanici_id;
    public void BilgileriYazdir()
    {
        Console.WriteLine(this.kullanici_ad+""+this.kullanici_parola+""+this.kullanici_id);
    }
}

