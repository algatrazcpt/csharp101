// See https://aka.ms/new-console-template for more information
Console.WriteLine("While Foreach");
int sayi=10;
int sayac=1;
int toplam=0;
while(sayac<=sayi)
{
    toplam+=sayac;
    sayac++;
}

string[] arabalar={"Araba1","Araba2","Araba3","Araba4"};
foreach(string araba in arabalar)
{
    Console.WriteLine(araba);
}
Console.ReadKey();