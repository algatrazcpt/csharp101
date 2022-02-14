Console.WriteLine("DateTime ve Math");

Console.WriteLine(DateTime.Now);
Console.WriteLine(DateTime.Now.Date);
Console.WriteLine(DateTime.Now.Day);
Console.WriteLine(DateTime.Now.Month);
Console.WriteLine(DateTime.Now.Year);
Console.WriteLine(DateTime.Now.Hour);
Console.WriteLine(DateTime.Now.Minute);

Console.WriteLine(DateTime.Now.DayOfWeek);
Console.WriteLine(DateTime.Now.DayOfYear);

Console.WriteLine(DateTime.Now.ToLongDateString());
Console.WriteLine(DateTime.Now.ToLongTimeString());

Console.WriteLine(DateTime.Now.AddDays(2));
Console.WriteLine(DateTime.Now.AddHours(2));

Console.WriteLine(DateTime.Now.ToString("dd"));
Console.WriteLine(DateTime.Now.ToString("ddd"));
Console.WriteLine(DateTime.Now.ToString("dddd"));


Console.WriteLine(Math.Abs(-25));
Console.WriteLine(Math.Sin(10));

Console.WriteLine(Math.Ceiling(24.9)); //Düşüge yuvarlar
Console.WriteLine(Math.Round(24.9)); //Hangisine daha yakınsa ona yuvarlar
Console.WriteLine(Math.Floor(24.1)); //yukarı yuvarlar

Console.WriteLine(Math.Max(1,9));
Console.WriteLine(Math.Min(1,9));

Console.WriteLine(Math.Pow(3,3));
Console.WriteLine(Math.Sqrt(9));
