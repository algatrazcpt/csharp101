Console.WriteLine("Koleksiyonlar Dictionary");
//key,value
Dictionary<string,string> kullancilar=new Dictionary<string, string>();
kullancilar.Add("Ad1","Ad-soyad-1");
kullancilar.Add("Ad2","Ad-soyad-2");
kullancilar.Add("Ad3","Ad-soyad-3");
foreach(var item in kullancilar){
    Console.WriteLine(item);
    Console.WriteLine(item.Key+":"+item.Value);

}
//Eleman sayısını bulur
Console.WriteLine(kullancilar.Count);
//Sözlükte varmı bakar
Console.WriteLine(kullancilar.ContainsKey("Ad1"));
Console.WriteLine(kullancilar.ContainsValue("Ad-soyad-2"));
//Sözlükteki keyi siler
Console.WriteLine(kullancilar.Remove("Ad1"));
