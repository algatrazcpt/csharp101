using System.Collections;
using System.Text.RegularExpressions;
string soru2_metni="soru2-(2 )Girilen sayılar istenen sayıya eşit veya tam bölününlerini bul";
Console.WriteLine(soru2_metni);
static void DiziYazdir(ArrayList dizi,string metin){
        foreach(var a in dizi){
            Console.WriteLine(metin+a);

        }
}
        Console.Write("Tanımlanacak sayı miktarı:");
        int uzunluk=Convert.ToInt32(Console.ReadLine());
        Console.Write("Özel sayı:");
        int ozel_sayi=Convert.ToInt32(Console.ReadLine());

        ArrayList arlist = new ArrayList(); 
        for(int sayac=0;sayac<uzunluk;sayac++){
            Console.Write("sayı {0} = ",(sayac+1));
            int sayi=Convert.ToInt32(Console.ReadLine());
            if (ozel_sayi==0)continue;
            if(sayi%ozel_sayi==0){
                arlist.Add(sayi);
            }
        }
        DiziYazdir(arlist,"Özel sayıya eşit veya tam bölünen sayı= ");
Console.ReadKey();