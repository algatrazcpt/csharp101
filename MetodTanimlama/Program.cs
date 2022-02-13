Console.WriteLine("Metod Tanimlama");
int a=1;
int b=2;
int sonuc=Topla(a,b);
Console.WriteLine(sonuc);
Console.WriteLine("a:"+a+" b:"+b);
int sonuc2=RefTopla(ref a,ref b);
int RefTopla(ref int deger1,ref int deger2)
{
    int sonuc=deger1+deger2;
    deger1++;
    deger2++;
    return sonuc;

}
// referans verilen degerin adresinde degisiklik yapar
Console.WriteLine(sonuc2);
Console.WriteLine("a:"+a+" b:"+b);

int Topla(int a,int b){

    return a+b;
}