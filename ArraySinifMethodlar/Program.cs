// See https://aka.ms/new-console-template for more information
Console.WriteLine("Array Sinif Methodlari");

int[] dsayi={1,4,3,2,5,6};
Console.WriteLine("Sırasız");
foreach(int a in dsayi){

    Console.WriteLine(a);
}
Console.WriteLine("Sıralı");
Array.Sort(dsayi);
foreach(int a in dsayi){
    Console.WriteLine(a);
}
Console.WriteLine("Ters çevirir");
Array.Reverse(dsayi);
foreach(int a in dsayi){
    Console.WriteLine(a);
}

Console.WriteLine("Diziyi siler");
Array.Clear(dsayi,2,1);
//2 inci elemandan itibaren bir uzunluguna kadar siler
foreach(int a in dsayi){
    Console.WriteLine(a);
}

Console.WriteLine("Elemanın indexini bulur");
Console.WriteLine(Array.IndexOf(dsayi,2));

Console.WriteLine("Diziyi yeniden boyutlandırır");
Array.Resize<int>(ref dsayi,10);
dsayi[9]=10;
foreach(int a in dsayi){
    Console.WriteLine(a);
}
Console.ReadKey();