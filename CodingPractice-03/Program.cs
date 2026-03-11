using System;
using System.Collections.Generic;

//1
{
    var tuple = (1, 2);
    var tuple2 = (1, 2);
    var tuple3 = (2, 3);
    Console.WriteLine(tuple.Equals( tuple2));
    Console.WriteLine(tuple.Equals( tuple3));
}

//2
{
    var tuple = (1, 2);
    var tuple2 = (1, 2);
    var tuple3 = (2, 3);
    Console.WriteLine(tuple==tuple2);
    Console.WriteLine(tuple!=tuple2);

}

//3
{
    (string c, string d) tuple = ("Alice", "25");
    (string a, string b) tuple2 = tuple;
    Console.WriteLine($"{tuple2.a} {tuple2.b}");
}

//4
{
    (string name, int age, char sex) tuple = ("Bob", 23, 'M');
    (string age, int sex, char name) tuple2 = tuple;
    Console.WriteLine($"{tuple2.age}\n{tuple2.sex}\n{tuple2.name}");
}

//5
{
    List<(string name, int age)> aa = new()
    {
        ("Alice", 25),
        ("Bob", 30),
        ("Charlie", 35)
    };
    foreach( var a in aa)
    {
        Console.WriteLine($"{a.name}: {a.age}세"); 
    }
}

//6
{
    Dictionary<(int x, int y), string> d = new()
    {
        {(0,0), "원점" },
        {(1,0), "오른쪽" }
    };

    Console.WriteLine($"{d[(0, 0)]}\n{d[(1,0)]}");
}

//7
{
    var tuple = new Tuple<string, int>("Bob", 23);
    var tuple2 = Tuple.Create("Alice", 25);
    Console.WriteLine($"{tuple.Item1}, {tuple.Item2}\n{tuple2.Item1}, {tuple2.Item2}");
}