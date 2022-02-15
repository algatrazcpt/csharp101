TohumluBitkiler thmbitki1=new TohumluBitkiler();
thmbitki1.Beslenme();
thmbitki1.Solunum();
thmbitki1.TohumlaCogalma();
Console.ReadKey();

class Canlılar{
    public void Beslenme()
    {
        Console.WriteLine("Canlılar beslenir");
    }
    public void Solunum()
    {
        Console.WriteLine("Canlılar solunum yapar");
    }


}

class Hayvanlar:Canlılar {
    public void Adaptasyon()
    {
        Console.WriteLine("Hayvanlar adepte olur");
    }
}
class Bitkiler:Canlılar{
    
    protected void Fotosentez()
    {
        Console.WriteLine("Bitkiler fotosentez yapar");
    }
}
class TohumluBitkiler:Bitkiler{
    public TohumluBitkiler()
    {
        base.Fotosentez();
    }
    public void TohumlaCogalma()
    {
        Console.WriteLine("Tohumlu Bitkiler tohumla cogalır ");
    }
}
class TohumsuzBitkiler:Bitkiler{
    public TohumsuzBitkiler()
    {
        base.Fotosentez();
    }
    public void SporlaCogalma()
    {
        Console.WriteLine(" Tohumsuz Bitkiler sporla cogalır ");
    }
}