using System.Collections;
using System.Text.RegularExpressions;
string soru4_metni="Soru4-(4 )Girilen metindeki Kelimeleri ve harfleri bul";
Console.WriteLine(soru4_metni);
        Console.Write("Cümle:");
        string cumle=Console.ReadLine().ToLower();
        int kelime_sayi=0;
        int harf_sayi=0;
        Regex rg = new Regex("[a-z]");
        foreach(string kelime in cumle.Split(" "))
        {
            var v=rg.Matches(kelime);
            if (v.Count==kelime.Length)
            {
                kelime_sayi++;
                harf_sayi+=kelime.Length;
            }
        }
        Console.WriteLine("Kelime Sayısı="+kelime_sayi+" Harf Sayısı="+harf_sayi);
        Console.ReadKey();