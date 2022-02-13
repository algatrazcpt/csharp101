// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hazır Methodlar");
string metin="C# ve Hazır Methodlar";
string metin2="testverisi";
//metnin uzunlugunu vverir
Console.WriteLine(metin.Length);
// toUpper hepsini büyük harf yapar toLower kücültür
Console.WriteLine(metin.ToLower());
Console.WriteLine(metin.ToUpper());
//concat iki metni birlestirir
Console.WriteLine(String.Concat("testverisi",metin));
//compare ve compare to karşılastırır
Console.WriteLine(metin.CompareTo(metin2));
Console.WriteLine(String.Compare(metin,metin2));
//Contains metinde arama yapar ends with son karakterleri kontrol eder start baslangıc karakterlerini kontrol eder
Console.WriteLine(metin.Contains("a"));
Console.WriteLine(metin.EndsWith("a"));
Console.WriteLine(metin.StartsWith("C"));
//indexof verilen degerin indexini bulur lastindex son indexteki alır
Console.WriteLine(metin.IndexOf("a"));
Console.WriteLine(metin.IndexOf("Hazır"));
Console.WriteLine(metin.LastIndexOf("a"));
//insert indexe ekleme yapar
Console.WriteLine(metin.Insert(0,"ABC"));
//padleft soluna bosluk atar padright sagına bosluk atar
Console.WriteLine(metin.PadLeft(30));
Console.WriteLine(metin.PadRight(30,'2'));
//remove belli aralıgı ve ya indexi siler
Console.WriteLine(metin.Remove(0));
Console.WriteLine(metin.Remove(0,2));
//replace yerine yazar
Console.WriteLine(metin.Replace(" ","*"));
//split metni böler
Console.WriteLine(metin.Split("*")[0]);
//substring index aralıgını alır
Console.WriteLine(metin.Substring(4));
Console.WriteLine(metin.Substring(4,6));
Console.ReadKey();

