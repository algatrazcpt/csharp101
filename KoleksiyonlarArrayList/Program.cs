using System.Collections;

Console.WriteLine("Koleksiyonlar Arraylist");

ArrayList arrayList=new ArrayList();
arrayList.Add("metin");
arrayList.Add(5);

int[] liste={1,2,3,4,5,6,7,9};
List<string> genericlist=new List<string>{"1,2,3,4,5,6,7,8"};

arrayList.AddRange(liste);
arrayList.AddRange(genericlist);

//reverse ters cevirir
arrayList.Reverse();
//binarysearach elemanın indexini getirir
//icindeki verilerin hepsi aynı turde degilse hata verir
arrayList.BinarySearch("metin");
arrayList.Sort();
//

foreach(var v in arrayList)
{
    Console.WriteLine(v);
}