Console.WriteLine("Generic Koleksiyonlar ve List");
List<int> sayiliste=new List<int>();
sayiliste.Add(10);
sayiliste.Add(30);
sayiliste.Add(5);
List<string> renkler=new List<string>();
renkler.Add("mavi");
renkler.Add("kırmızı");
renkler.Add("siyah");
//count 
Console.WriteLine(renkler.Count);
//
foreach(int a in sayiliste)
{
    Console.WriteLine(a);
}
sayiliste.Remove(5);
renkler.Remove("1");
//
sayiliste.RemoveAt(0);
renkler.RemoveAt(0);

//list.Foreach
sayiliste.ForEach(sayi=>Console.WriteLine(sayi));
renkler.ForEach(renk=>Console.WriteLine(renk));
//
if (sayiliste.Contains(30))
Console.WriteLine("30 listede bulundu");
//elemanın indexini ulasır
Console.WriteLine(renkler.BinarySearch("kırmızı"));
//
string[]hayvanlar={"kedi,köpek,kuş"};
List<string> hayvanliste=new List<string>(hayvanlar);
//
List<kullanicilar> kullaniciliste=new List<kullanicilar>();
kullanicilar kullanici=new kullanicilar();
kullanici.Isım="İsim1";
kullanici.SoyAd="Soyad1";
kullanici.Yas=1;
kullaniciliste.Add(kullanici);
kullanici=new kullanicilar();
kullanici.Isım="İsim2";
kullanici.SoyAd="Soyad2";
kullanici.Yas=1;
kullaniciliste.Add(kullanici);
kullaniciliste.ForEach(deger=> Console.WriteLine(deger.Isım+deger.SoyAd+deger.Yas));
public class kullanicilar{
    private string kn_ad;
    private string kn_soyad;
    private int kn_yas;
    public string Isım{get=>kn_ad;set=>kn_ad=value;}
    public string SoyAd{get=>kn_soyad;set=>kn_soyad=value;}
    public int Yas{get=>kn_yas;set=>kn_yas=value;}
}