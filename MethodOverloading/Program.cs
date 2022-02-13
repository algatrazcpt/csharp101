using System;

namespace MethodOverloading // Note: actual namespace depends on the project name.
{

    public class Snf{
        public int toplama(int a,int b){

            return a+b;
        }
       public int toplama(int a,int b,int c){

            return a+b+c;
        }
    }
    // OVerloading class içinde degilse hata verir
     class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Method Overloading");
            string sayi="s999";
            int outsayi=0;
            bool sonuc=int.TryParse(sayi,out outsayi);
            //out varsayılan deger olarak atar işlem yapılamazsa başlangıc degerini kulalnır
            if (sonuc){
                Console.WriteLine("Basarili");
                Console.WriteLine(outsayi);

            }
            else{
                Console.WriteLine("Basarisiz");
                Console.WriteLine(outsayi);
            }
            
            Snf snf = new Snf();
    

            Console.WriteLine(snf.toplama(1,2));
            Console.WriteLine(snf.toplama(1,2,3));
        }
    }

}

