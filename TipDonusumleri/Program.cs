// See https://aka.ms/new-console-template for more information
Console.WriteLine("Tip Döşümleri");
// implicit Conversion

// stringi 24 saate cevirir
string s="12:07:45PM";
var k=DateTime.Parse(s).ToString("HH:mm:ss");
Console.WriteLine(k.ToString());

byte a=1;
sbyte b=1;
short c=3;
int d=a+b+c;
long h=d;

string  e="metin";
char f='c';
object g=e+f+d;
Console.WriteLine(g);


//Explicit conversion

int x=4;
byte y=(byte)x;
Console.WriteLine(y);

int z=100;
byte t=(byte)z;

// parse

string s20="20";
int i20=Int32.Parse(s20);
Console.WriteLine(i20);

Console.ReadKey();