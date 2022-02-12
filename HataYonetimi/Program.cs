// See https://aka.ms/new-console-template for more information



Console.WriteLine("Hata Yönetimi");
try
{
    

Console.WriteLine("Bir sayi giriniz");
int a=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Girilen sayi:"+a);

}

catch(ArgumentException e)
{

Console.WriteLine(e.Message.ToString());
}
catch(Exception e)//Bütün hataları yakalar
{

Console.WriteLine(e.Message.ToString());
}
finally
{
    Console.ReadKey();
}