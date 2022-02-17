İslemler kullanici_islemler=new İslemler();

    
    while (true){
    Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz :) ");
    Console.WriteLine("*******************************************");
    Console.WriteLine("(1) Kart  Ekle");
    Console.WriteLine("(2) Kart Güncelle");
    Console.WriteLine("(3) Kart Sil");
    Console.WriteLine("(4) Kart Taşı");
    Console.WriteLine("(5) Kartları Listele");
    Console.WriteLine("(6) Çıkış");
    Console.Write("İslemlerden birini seçiniz (1-2-3-4-5-6)");
    //
    int tercih =Convert.ToInt32(Console.ReadLine());
        if (tercih==1)
        {
                kullanici_islemler.KartEkle();
                Console.WriteLine("**********************************************");
                kullanici_islemler.KartlarıListele();
        }
        else if (tercih==2)
        {
                kullanici_islemler.KartGuncelle();
                Console.WriteLine("**********************************************");
                kullanici_islemler.KartlarıListele();
        }
        else if (tercih==3)
        {
                kullanici_islemler.KartSil();
                Console.WriteLine("**********************************************");
                kullanici_islemler.KartlarıListele();
        }
        else if (tercih==4)
        {
                kullanici_islemler.KartTasima();
                Console.WriteLine("**********************************************");
                kullanici_islemler.KartlarıListele();
        }
        else if (tercih==5)
        {
                kullanici_islemler.KartlarıListele();
                Console.WriteLine("**********************************************");
        }
        else if (tercih==6)
        {
                break;
        }
    }

class İslemler{
private AllBoard todo=new AllBoard("TODO LİNE");
private AllBoard progres=new AllBoard("IN PROGRES LİNE");
private AllBoard done =new AllBoard("DONE LİNE");
Dictionary<int,string> kisiler=new Dictionary<int,string>();
 public İslemler()
{
    //
    kisiler[1]="Test";
    kisiler[2]="Backend";
    kisiler[3]="Frontend";
    kisiler[4]="Game";
    //
    todo.board.Add(new Board("baslik1","icerik1",1,kisiler[1]));
    progres.board.Add(new Board("baslik2","icerik2",2,kisiler[2]));
    done.board.Add(new Board("baslik3","icerik3",3,kisiler[3]));

}
public void KartTasima(){
        Console.WriteLine("Öncelikle Taşıma istediğiniz kartı seçmeniz gerekiyor.");
        Console.Write("Lütfen kart başlığını yazınız: ");
        string baslik=Console.ReadLine();
        Console.Write("Lütfen Taşıncak  (Todo)-1 (Progres)-2 (Done)-3 tercih yapınız: ");
        int board_no=Convert.ToInt32(Console.ReadLine());
        var vtodo=todo.BoardGetir(baslik);
        var vprogres=progres.BoardGetir(baslik);
        var vdone=done.BoardGetir(baslik);
        var deger= new Board();
        bool degerlendirme=(board_no==1)|(board_no==2)|(board_no==3);
        if (vtodo!=null){
            deger=vtodo;
            if(degerlendirme){
            todo.board.Remove(vtodo);
            }
        }
        else if (vprogres!=null){
            deger=vprogres;
            if(degerlendirme)
            {
            progres.board.Remove(vprogres);
            }
        }
        else if (vdone!=null){
            deger=vdone;
            if(degerlendirme){
            done.board.Remove(vdone);
            }
        }
        else{
            Console.WriteLine("Baslik  Bulunamadı");
        }
        if(degerlendirme){
            if (board_no==1)
            {
                todo.board.Add(deger);
            }
            else if (board_no==2)
            {
                progres.board.Add(deger);
            }
            else if (board_no==3)
            {
                done.board.Add(deger);
            }
        }

}
public void KartlarıListele(){
    todo.EkranaYazdir();
    progres.EkranaYazdir();
    done.EkranaYazdir();
}
public void KartGuncelle(){
        Console.WriteLine("Öncelikle Güncellemek istediğiniz kartı seçmeniz gerekiyor.");
        Console.Write(" Lütfen kart başlığını yazınız: ");
        string baslik=Console.ReadLine();
        var vtodo=todo.BoardGetir(baslik);
        var vprogres=progres.BoardGetir(baslik);
        var vdone=done.BoardGetir(baslik);
        
        if (vtodo!=null){
            GuncelleBilgiAl(vtodo);
        }
        else if (vprogres!=null){
            GuncelleBilgiAl(vprogres);
        }
        else if (vdone!=null){
            GuncelleBilgiAl(vdone);
        }
        else{
            Console.WriteLine("Baslık Bulunamadı");
        }
}
public void GuncelleBilgiAl(Board brd)
{
     Console.Write("Başlık Giriniz                                  :");
    string baslik=Console.ReadLine();
    Console.Write("İçerik Giriniz                                  :");
    string icerik=Console.ReadLine();
    Console.Write("Büyüklük Seçiniz -> XS(1),S(2),M(3),L(4),XL(5)  :");
    int buyukluk=Convert.ToInt32(Console.ReadLine());
    Console.Write("Kişi Seçiniz     ->  (1),(2),(3),(4)            :");
    int kisi=Convert.ToInt32(Console.ReadLine());
    brd.Baslik=baslik;
    brd.Iceirk=icerik;
    brd.Buyukluk=buyukluk;
    brd.Atanan_kisi=kisiler[kisi];
    Console.WriteLine("Güncellenmiş Veri");
    brd.EkranaYazdir();
}

public void KartEkle()
{

 Console.Write("Başlık Giriniz                                  :");
 string baslik=Console.ReadLine();
 Console.Write("İçerik Giriniz                                  :");
 string icerik=Console.ReadLine();
 Console.Write("Büyüklük Seçiniz -> XS(1),S(2),M(3),L(4),XL(5)  :");
 int buyukluk=Convert.ToInt32(Console.ReadLine());
 Console.Write("Kişi Seçiniz     ->  (1),(2),(3),(4)            :");
 int kisi=Convert.ToInt32(Console.ReadLine());
 //
 todo.board.Add(new Board(baslik,icerik,buyukluk,kisiler[kisi]));
 //
}
public void KartArama(){
        Console.WriteLine("Öncelikle aramak istediğiniz kartı seçmeniz gerekiyor.");
        Console.Write(" Lütfen kart başlığını yazınız: ");
        string baslik=Console.ReadLine();
        Console.WriteLine("Bulunan Kart Bilgileri:");
        Console.WriteLine("**************************************");
        if (todo.BoardIciArama(baslik) | progres.BoardIciArama(baslik) | done.BoardIciArama(baslik))
        {

        }
        else
        {
            Console.WriteLine("Aradığınız krtiterlere uygun kart board'da bulunamadı.");
        }
        Console.WriteLine("**************************************");
}
public void KartSil(){

    Console.WriteLine("Öncelikle silmek istediğiniz kartı seçmeniz gerekiyor.");
    while(true){
        Console.Write(" Lütfen kart başlığını yazınız: ");
        string baslik=Console.ReadLine();
        if (todo.BoardIciSilme(baslik) | progres.BoardIciSilme(baslik) | done.BoardIciSilme(baslik))
        {
            break;
        }
        else{
            Console.WriteLine("Aradığınız krtiterlere uygun kart board'da bulunamadı. Lütfen bir seçim yapınız.");
            Console.WriteLine("*Silmeyi sonlandırmak için : (1)");
            Console.WriteLine("*Yeniden denemek için      : (2)");
            string tercih=Console.ReadLine();
            if (tercih=="1"){
                break;
            }
            else if (tercih=="2"){
                break;
            }
            
        }
    }
    }
}


class AllBoard{
    public  List<Board> board=new List<Board>();
    public string baslik="";
    public AllBoard(string baslik)
    {
        this.baslik = baslik;
    }

    public void EkranaYazdir()
    {
         Console.WriteLine(baslik);
         Console.WriteLine("**************************************");
         foreach(var v in board){
             v.EkranaYazdir();
         }
         if (board==null){
              Console.WriteLine("~ BOŞ ~");
         }
    }
    
    public bool BoardIciSilme(string arama_metni)
    {
        bool durum=false;
            if (board==null)
            {
              Console.WriteLine("~ BOŞ ~");
              return durum;
            }
            while(true)
            {
                int ind=board.FindIndex(veri => veri.Baslik.ToLower() == arama_metni.ToLower());
                if (ind>=0){
                    board.RemoveAt(ind);
                    durum=true;
                }
                else{
                    break;
                }
            }
        return durum;
    }
    public void BoardIciSilmeHizli(Board vboard)
    {
        board.Remove(vboard);
    }
    public bool BoardIciArama(string arama_metni)
    {
        bool durum=false;
            if (board==null)
            {
              Console.WriteLine("~ BOŞ ~");
              return durum;
            }
            for (int a=0;a<board.Count;a++)
            {
                int ind=board.FindIndex(veri => veri.Baslik.ToLower() == arama_metni.ToLower());
                if (ind>=0){
                    board[ind].EkranaYazdir();
                    durum=true;
                }
                else{
                    break;
                }
            }
        return durum;
    }
    public Board BoardGetir(string arama_metni)
    {
            if (board==null)
            {
              Console.WriteLine("~ BOŞ ~");
            }                
            int ind=board.FindIndex(veri => veri.Baslik.ToLower() == arama_metni.ToLower());
            if (ind>=0)
            {
                return board[ind];
            }
            else
            {
                return null;
            }
    }
}


class Board
{
    private string baslik;
    private string icerik;
    private string atanan_kisi;
    private int buyukluk;

    public Board()
    {
        
    }
    public Board(string baslik1, string icerik1, int buyukluk1,string atanan_kisi1 )
    {
        baslik = baslik1;
        icerik = icerik1;
        buyukluk = buyukluk1;
        atanan_kisi = atanan_kisi1;

    }

    public string Baslik { get => baslik; set => baslik = value; }
    public string Iceirk { get => icerik; set => icerik = value; }
    public string Atanan_kisi { get => atanan_kisi; set => atanan_kisi = value; }
    public int Buyukluk { get => buyukluk; set => buyukluk = value; }

    public void EkranaYazdir(){
        Console.WriteLine("Baslik       :   {0}",baslik);
        Console.WriteLine("İçerik       :   {0}",icerik);
        Console.WriteLine("Atanan Kişi  :   {0}",atanan_kisi);
        Console.WriteLine("Büyüklük     :   {0}",(Buyukluk)buyukluk);
        Console.WriteLine("-");
    }
}

enum Buyukluk{
    XS=1,
    S=2,
    M=3,
    L=4,
    XL=5
}
