
//Polymorphism
Bitkiler agac=new Bitkiler();

agac.Beslenme();
agac.Bosaltim();
agac.HareketlereTepki();
agac.solunum();
Hayvanlar kedi=new Hayvanlar();
kedi.Beslenme();
kedi.Bosaltim();
kedi.HareketlereTepki();
kedi.solunum();
//Sealed class
Muhurlu mhrlsinif=new Muhurlu();

Console.ReadKey();
class Canlılar{

    public void Bosaltim(){
        Console.WriteLine("Canlılar bosaltım yapar");
    }
    public void solunum(){
        Console.WriteLine("Canlılar solunum yapar");
    }
    public virtual void Beslenme(){
        Console.WriteLine("Canlılar solunum yapar");
    }
    public virtual void HareketlereTepki(){
        Console.WriteLine("Canlılar hareketlere tepki verir");
    }
}
class Hayvanlar:Canlılar{

public override void Beslenme(){
    Console.WriteLine("Hayvanlar Etobur,Otobur beslenirler");
}
public override void HareketlereTepki(){
    Console.WriteLine("Hayvanlar hareketlere tepki verir");
}

}
class Bitkiler:Canlılar{
    public override void Beslenme()
    {
        Console.WriteLine("Bitkiler su ve güneş ile beslenir");
    }
    public override void HareketlereTepki()
    {
        Console.WriteLine("Bitkiler hareketlere direk tepki vermez");
    }

}
public sealed class Muhurlu{

public  Muhurlu(){
    Console.WriteLine("Muhurlu  sınıftan kalıtım yapılamaz ");
}


}