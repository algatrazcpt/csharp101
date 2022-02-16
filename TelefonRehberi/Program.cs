//
Kullaniciİslemleri islem1=new Kullaniciİslemleri();
islem1.TemelKullanici();
//
while(true){
    //
    Console.WriteLine("1-Telefon Numarası Kaydet");
    Console.WriteLine("2-Telefon Numarası Sil");
    Console.WriteLine("3-Telefon Numarası Güncelle");
    Console.WriteLine("4-Rehber Listeleme");
    Console.WriteLine("5-Rehberde Arama");
    Console.WriteLine("6-Çıkmak İçin");
    
    Console.Write("İslemlerden birini seçiniz (1-2-3-4-5-6)");
    //
    int tercih =Convert.ToInt32(Console.ReadLine());
    if (tercih==1)
    {
            islem1.KullaniciEkle();
            Console.WriteLine("**********************************************");
    }
    else if (tercih==2)
    {
            islem1.KullaniciSil();
            Console.WriteLine("**********************************************");
    }
    else if (tercih==3)
    {
            islem1.KullanicGuncelleme();
            Console.WriteLine("**********************************************");
    }
    else if (tercih==4)
    {
            islem1.KullaniciListeleme();
            Console.WriteLine("**********************************************");
    }
    else if (tercih==5)
    {
            islem1.KullaniciArama();
            Console.WriteLine("**********************************************");
    }
    else if (tercih==6)
    {
            break;
    }

}


static class Rehber{
 public static List<Kisi> rehberliste=new List<Kisi>();
    
}
class Kullaniciİslemleri{
    public void TemelKullanici()
    {
        Rehber.rehberliste.Add(new Kisi("ad1","soyad1","05555555551"));
        Rehber.rehberliste.Add(new Kisi("ad2","soyad2","05555555552"));
        Rehber.rehberliste.Add(new Kisi("ad3","soyad3","05555555553"));
        Rehber.rehberliste.Add(new Kisi("ad4","soyad4","05555555554"));
        Rehber.rehberliste.Add(new Kisi("ad5","soyad5","05555555555"));
    }
    public void KullaniciEkle()
    {
        Console.WriteLine("Yeni kişi oluştur");
        Console.Write("Lütfen isim giriniz             :");
        string ad=Console.ReadLine();
        Console.Write("Lütfen soyisim giriniz          :");
        string soyad=Console.ReadLine();
        Console.Write("Lütfen telefon numarası giriniz :");
        string no=Console.ReadLine();
        Rehber.rehberliste.Add(new Kisi(ad,soyad,no));
        
    }
    public void KullanicGuncelleme(){
        while (true){
            Console.Write("Lütfen  güncellemek istediğiniz kişinin adını ya da soyadını giriniz:");
            string metin="* Güncellemeyi sonlandırmak için : (1)";
            string arama_metni=Console.ReadLine();
            var v=KullaniciArama(arama_metni);
            if (v==null)
            {
                if(Kontrol(metin)==false){
                    break;
                }
            }
            else
            {
                v.KullaniciGetir();
                Console.Write("Yeni No:");
                v.No=Console.ReadLine();
                break;
            }
        
        }

    }
    public Kisi KullaniciArama(string arananMetin)
    {
        foreach(var v in Rehber.rehberliste )
        {
            if (v.Ad==arananMetin | v.Soyad==arananMetin)
            {
                return v;
            }
            
        }
        return null;
    }
    public void KullaniciArama()
    {
        Console.WriteLine("Arama yapmak istediğiniz tipi seçiniz.");
        Console.WriteLine("**********************************************");
        Console.WriteLine("İsim veya soyisime göre arama yapmak için: (1)");
        Console.WriteLine("Telefon numarasına göre arama yapmak için: (2)");
        int a= Convert.ToInt16(Console.ReadLine());
        Console.Write("Arancak metin:");
        string arananMetin=Console.ReadLine();
        if(a==1)
        {
            foreach(var v in Rehber.rehberliste )
            {
                if (v.Ad==arananMetin | v.Soyad==arananMetin)
                {
                    v.KullaniciGetir();
                }
            }
        }
        else if (a==2)
        {
            foreach(var v in Rehber.rehberliste )
            {
                if (v.No==arananMetin)
                {
                    v.KullaniciGetir();
                }
            }
        }
    }
    public void KullaniciListeleme()
    {
        foreach(var v in Rehber.rehberliste)
        {
            v.KullaniciGetir();
        }
    }


    public bool Kontrol(string metin1 )
    {
        Console.WriteLine("Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.");
        Console.WriteLine(metin1);
        Console.WriteLine("* Yeniden denemek için      : (2)");
        int tercih=Convert.ToInt32(Console.ReadLine());
        if (tercih==1){
            return false;
        }
        else
        {
            return true;
        }
    }


    public void KullaniciSil()
    {
        while (true)
        {
            Console.Write("Lütfen numarasını silmek istediğiniz kişinin adını ya da soyadını giriniz:");
            string metin="* Silmeyi sonlandırmak için : (1)";
            string arama_metni=Console.ReadLine();
            var v=KullaniciArama(arama_metni);
            if (v==null)
            {
                if(Kontrol(metin)==false)
                {
                    break;
                }
            }
            else
            {
                Console.Write("{0} isimli kişi rehberden silinmek üzere, onaylıyor musunuz ?(y/n)",v.Ad);
                if (Console.ReadLine().ToLower()=="y")
                {
                    Rehber.rehberliste.Remove(KullaniciArama(arama_metni));
                    break;
                }
                else
                {
                    break;
                }
                
            }
        
        }
    }


}

class Kisi{
    private string ad;
    private string soyad;
    private string no;

    public string No { get => no; set => no = value; }
    public string Soyad { get => soyad; set => soyad = value; }
    public string Ad { get => ad; set => ad = value; }

    public Kisi(string ad,string soyad,string no)
    {
        this.Ad=ad;
        this.Soyad=soyad;
        this.No=no;

    }
    public Kisi()
    {
    }

    public void KullaniciGetir()
    {
          Console.WriteLine("isim: {0}",Ad);
          Console.WriteLine("Soyisim: {0}",Soyad);
          Console.WriteLine("Telefon Numarası: {0}",No);
          Console.WriteLine("-".PadLeft(30,'-'));
    }
    
    
}
