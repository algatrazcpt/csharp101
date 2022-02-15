Calisanlar calisan1=new Calisanlar();
calisan1.ad="calışan1-ad";
calisan1.soyad="calışan1-soyad";
calisan1.no=1;
calisan1.departman="departman1";
calisan1.CalisaniYazdir();

calisan1=new Calisanlar("calışan2-ad","calışan2-soyad",2,"departman1");
calisan1.CalisaniYazdir();

Console.ReadKey();
class Calisanlar{
    public string ad;
    public string soyad;
    public int no;
    public string departman;
    public Calisanlar(){
    }
    public Calisanlar(string ad,string soyad,int no,string departman){
        this.ad=ad;
        this.soyad=soyad;
        this.no=no;
        this.departman=departman;

    }
    public void CalisaniYazdir()
    {
        Console.WriteLine( this.ad+"-"+this.soyad+"-"+ this.no+"-"+ this.departman);
    }


}


