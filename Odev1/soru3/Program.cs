using System.Collections;
using System.Text.RegularExpressions;
string soru3_metni="soru3-(3 )Girilen kelimeleri ters sırala ";
Console.WriteLine(soru3_metni);
static void DiziYazdir(ArrayList dizi,string metin){
        foreach(var a in dizi){
            Console.WriteLine(metin+a);

        }
}
        Console.Write("Tanımlanacak kelime miktarı:");
        int uzunluk=Convert.ToInt32(Console.ReadLine());
        ArrayList arlist = new ArrayList(); 
        for(int sayac=0;sayac<uzunluk;sayac++){
            Console.Write("kelime {0} = ",(sayac+1));
            arlist.Add(Console.ReadLine());
        }
        arlist.Reverse();
        DiziYazdir(arlist,"");
Console.ReadKey();