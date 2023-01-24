// See https://aka.ms/new-console-template for more information

//https://github.com/ardalis/SmartEnum

using SmartEnumExample.SmartEnums;

Console.WriteLine("Hello, World!");

var t1=ExampleEnum1.One.Equals(ExampleEnum1.One); // returns true
Console.WriteLine(t1);
var t2=ExampleEnum1.One.Equals(ExampleEnum1.Three); // returns false
var t3=ExampleEnum1.Three.Equals(ExampleEnum1.AnotherThree); // returns true

foreach (var option in ReservationStatus.List)
    Console.WriteLine(option.Name);

var count = ReservationStatus.List.Count;
Console.WriteLine(count);

var myEnum1 = ExampleEnum1.FromName("One");

if (ExampleEnum1.TryFromName("One", out var myEnum))
{
    var t = myEnum;
    // use myEnum here
}

var myEnum2 = ExampleEnum1.FromValue(1);

if (ExampleEnum1.TryFromValue(1, out var myEnum3))
{
    // use myEnum here
}



Console.ReadKey();