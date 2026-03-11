using System;

//1
{
    var tuple = ("bob", 23);
    Console.WriteLine($"{tuple.Item1}\n{tuple.Item2}");
}

//2-1
{
    var tuple = (12, 34, 56);
    Console.WriteLine($"{tuple.Item1}, {tuple.Item2}, {tuple.Item3}");
}

//2-2
{
    var tuple = ("Hello", 100, true, 3.14);
    Console.WriteLine($"{tuple.Item1}, {tuple.Item2}, {tuple.Item3}, {tuple.Item4}");
}

//3-1
{
    (string, int) tuple = ("Alice", 25);
}

//3-2
{
    (ushort Width, ushort Height) tuple = (1920, 1080);
    Console.WriteLine($"해상도: {tuple.Width} x {tuple.Height}");
}

//4
{
    var tuple = ("Bob", 23);
    string a = tuple.Item1;
    int b = tuple.Item2;
    a = "Joe";

    Console.WriteLine($"원본: ({tuple.Item1}, {tuple.Item2})\n복사본: ({a}, {b})");
}

//5
{
    var tuple = (name: "Bob", age: 23);
    Console.WriteLine($"{tuple.Item1}\n{tuple.Item2}\n{tuple.name}\n{tuple.age}");
}

//6
{
    (string Name, bool IsStudent, int OrderPrice) tuple = ("철수", true, 1000);
    Console.WriteLine($"{tuple.Name}(학생: {tuple.IsStudent}) - 주문: {tuple.OrderPrice:N0}원");
}

//7
{
    (string name, int age, char gender) tuple = ("Bob", 23, 'M');
    Console.WriteLine($"이름: {tuple.name}\n나이: {tuple.age}\n성별: {tuple.gender}");
}

//8
{
    var tuple = DateTime.Now;
    Console.WriteLine($"일: {tuple.Day}\n월: {tuple.Month}\n년: {tuple.Year}");
}