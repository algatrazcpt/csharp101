
Console.WriteLine("İf else - Ternary İf");

int saat=DateTime.Now.Hour;

if(saat>5 && saat<11)
{
    Console.WriteLine("Günaydın");
}
else if(saat<=18)
{
    Console.WriteLine("İyi Günler");
}
else {
    Console.WriteLine("İyi Geceler");
}
string sonuc=saat<18 ?"İyi Günler" :"iyi geceler";

Console.WriteLine(sonuc);

sonuc= saat<11 &saat>5?"Günaydın" : saat<=18 ? "İyi Günler":"İyi Geceler";
Console.WriteLine(sonuc);
Console.ReadKey();