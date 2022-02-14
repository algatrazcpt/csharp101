using System.Text.RegularExpressions;

Console.Write("Cümle giriniz:");
//Bütün degerleri kücülttük
string metin=Console.ReadLine().ToLower();
//
string pattern = "[aeıioöuü]";  
//
Regex rg = new Regex(pattern);  
var sonuc = rg.Matches(metin);  
Console.WriteLine("Dizideki Sesli elemanlar");
foreach(var v in sonuc)
{
    Console.WriteLine(v);
}
Console.ReadKey();