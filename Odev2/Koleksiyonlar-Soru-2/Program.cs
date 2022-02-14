int[] dizi=new int[20];
for(int a=0;a<20;a++)
{
    Console.Write("Sayi {0}=",a+1);
    int deger=Convert.ToInt32(Console.ReadLine());
    dizi[a]=deger;
}
sayi_k(dizi);

 void sayi_k(int []td)
{
    //
    Array.Sort(td);
    //
    int mx1=td[19];
    int mx2=td[18];
    int mx3=td[17];
    
    //
    int mn1=td[0];
    int mn2=td[1];
    int mn3=td[2];
    //
    double mx=(mx1+mx2+mx3)/3;
    double mn=(mn1+mn2+mn3)/3;
    double tp=mx+mn;
    Console.WriteLine("Max 3 sayi {0} {1} {2}",mx1,mx2,mx3);
    Console.WriteLine("Min 3 sayi {0} {1} {2}",mn1,mn2,mn3);
    Console.WriteLine("maximum sayıların ortalaması {0}, minimum sayıların ortalaması {1} toplam sonuc {2}",mx,mn,tp);

}
Console.ReadKey();