using System.Collections;
using System.Text.RegularExpressions;
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Ödev1");
string soru1_metni="soru1-(1 )Girilen sayılardan çift olanlarını bul";

Console.WriteLine(soru1_metni);
static void DiziYazdir(ArrayList dizi,string metin){
foreach(var a in dizi){
Console.WriteLine(metin+a);
 }
}
        Console.Write("Tanımlanacak sayı miktarı:");
        int uzunluk=Convert.ToInt32(Console.ReadLine());

        ArrayList arlist = new ArrayList(); 
        for(int sayac=0;sayac<uzunluk;sayac++){
            Console.Write("sayı {0} = ",(sayac+1));
            int sayi=Convert.ToInt32(Console.ReadLine());
            if(sayi%2==0){
                arlist.Add(sayi);
            }


        }

DiziYazdir(arlist,"Çift Sayılar:");
Console.ReadKey();