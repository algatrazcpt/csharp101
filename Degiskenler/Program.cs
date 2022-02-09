using System;

namespace Degiskenler // Note: actual namespace depends on the project name.
{
     class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Degiskenler!");
            byte b=1;   //1 byte
            sbyte c=1;  // 1 byte

            short s=2;  //2 byte
            ushort us=2;    //2byte

            int i =4; //4 byte
            Int32 i32=4; //4 byte
            Int64 i64=8;   //8byte;

            uint ui=4;  //4byte
            long l=8; //8byte

            float f=4; //4byte
            double d=8; //8byte
            decimal de=16; //16 byte

            char ch='2';    //2byte
            string st="Sınırsız";   //sınırsız

            bool b1=true;

            DateTime dt=DateTime.Now;

            object o="coklu degiskenleri alır";
            object o1=4.2;

            string s1=string.Empty;
            s1="metin";

            //Degisken dönüsümleri

            string s20="20";
            int int20=20;
            string yenideger=s20+int20.ToString();

            int int21=int20+Convert.ToInt32(s20);

            string strdatetime=DateTime.Now.ToString("dd.MM.yyyy");
            Console.ReadKey();
        }
    }
}