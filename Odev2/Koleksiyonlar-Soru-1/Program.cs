
using System.Collections;

ArrayList asal=new ArrayList();
ArrayList nasal=new ArrayList();
 bool[] asal_sayilar={false,false,true};;
  bool Asal_mi(int sayi)
{
    if(asal_sayilar.Length<sayi+1)
    {

    
   asal_sayilar=new bool[sayi+1];

        //
        for(int a=0;a<sayi+1;a++)
        {
            asal_sayilar[a]=true;
        }
    }

    int p=2;
    while(p*p<=sayi){
        if (asal_sayilar[p]==true){

            for(int a=p*2;a<sayi+1;a+=p)
            {
                asal_sayilar[a]=false;
            }
        }
        p+=1;
    }
    return asal_sayilar[sayi];
}
    

int sayac=0;
while(sayac<20){
    try
    {
        Console.Write("Sayi {0} = ",sayac+1);
    int sayi=Convert.ToInt32(Console.ReadLine());
    if (sayi>=0){
        if (Asal_mi(sayi)){
        asal.Add(sayi);
        }
        else
        {
            nasal.Add(sayi);
        }
        
    }
    sayac++;
    }
    catch(Exception e){
        Console.WriteLine("Negatif sayı ve ya harf giremezsiniz");
    }
}
Console.WriteLine("Asal sayılar");
asal.Sort();
asal.Reverse();
double total_asal=0;
foreach(int a in asal)
{
    total_asal+=a;
    Console.WriteLine(a);
}
Console.WriteLine("Asal olmayanlar");
nasal.Sort();
nasal.Reverse();
double total_nasal=0;
foreach(int a in nasal)
{
    total_nasal+=a;
    Console.WriteLine(a);
    
}
int asal_boyut=1;
int nasal_boyut=1;
if (asal.Count>0)asal_boyut=asal.Count;
if(nasal.Count>0)nasal_boyut=nasal.Count;

Console.WriteLine("Asal sayıların miktari  {0} - Asal sayıların Ortalaması {1}",asal.Count,total_asal/asal_boyut);
Console.WriteLine("Asal olmayan sayıların miktari {0} - Asal  olmayan sayıların Ortalaması {1}",nasal.Count,total_nasal/nasal_boyut);

Console.ReadKey();
