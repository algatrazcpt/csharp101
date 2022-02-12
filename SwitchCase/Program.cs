Console.WriteLine("Switch Case");

int ay=DateTime.Now.Month;
string s_ay;
switch(ay)
{
    case 1:
        s_ay="OCAK";
        break;
    case 2:
        s_ay="ŞUBAT";
        break;
    case 3:
        s_ay="MART";
        break;
    case 4:
        s_ay="NİSAN";
        break;
    case 5:
        s_ay="MAYIS";
        break;
    default:
        s_ay="Ayın ismi mevcut degil";
        break;
}
Console.WriteLine(s_ay);
Console.ReadKey();
