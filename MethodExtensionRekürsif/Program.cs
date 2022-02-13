using System;  
  
namespace MethodExtensionRekürsif  
{  
    class Islemler{
        public int Expo(int a, int b)
        {
            if (b<2){
                return a;
            }
            return (Expo(a,b-1)*a);
        }

    }
    //gelen verinin method ekler
    public static class Extension{
        public static bool BoslukKontrol(this string veri){

             return veri.Contains(" ");
        }
       public static string SayiEkle(this string veri,int veri2){

             return veri+""+veri2;
        }
        public static string terscevir(this string veri){

             return new string(veri.Reverse().ToArray());
        }



    }


    class Program  
    {  
        static void Main(string[] args)  
        {  
            Console.WriteLine(" Method Extension  Rekürsif");
            Islemler islem=new Islemler();
            
            Console.WriteLine(islem.Expo(2,3));
            string metin="Hello world";
            Console.WriteLine(metin.SayiEkle(5));
            Console.WriteLine(metin.terscevir());

        }  
    }
}  




