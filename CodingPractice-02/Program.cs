using System;

//1
{
    var tuple = Tally();
    Console.WriteLine($"합계: {tuple.Item1}, 개수: {tuple.Item2}");
    static (int, int) Tally() => (12, 3);
}

//2
{
    var tuple = Calculate();
    Console.WriteLine($"합계: {tuple.Sum}, 개수: {tuple.Count}");
    static (int Sum, int Count) Calculate() => (45, 6);
}

//3
{
    var tuple = GetPair();
    Console.WriteLine($"{tuple.first}, {tuple.second}");
    static (int first, int second) GetPair() => (100, 200);
}

//4

{
    int[] array = { 5, 2, 8, 1,9,3};
    var tuple = FindMinMax(array);
    Console.WriteLine($"최솟값: {tuple.min}, 최댓값: {tuple.max}");

    static (int min, int max) FindMinMax(int[] numbers)
    {
        int min = numbers[0];
        int max = numbers[0];

        foreach (int num in numbers)
        {
            if (num < min)
            {
                min = num;
            }
            if (num > max)
            {
                max = num;
            }
        }
        return (min, max);

    }
}

//5
{
    var tuple = ZeroZero();
    Console.WriteLine($"{tuple.Item1}, {tuple.Item2}");
    static (int, int) ZeroZero() => default;
}

//6
{
    var tuple = ("Bob", 23);
    (string name, int age) = tuple;
    Console.WriteLine($"이름: {name}, 나이: {age}");
}

//7
{
    var (sum, count) = Tally();
    Console.WriteLine($"Sum: {sum}, Count: {count}");
    static (int, int) Tally() => (12, 3);

}

//8
{
    string name;
    int age;
    var tuple = ("Alice", 30);
    (name, age) = tuple;
    Console.WriteLine($"{name}, {age}");
}

//9
{
    var tuple = ("aa", 23, "ab");

    var (_, age, _) = tuple;

    Console.WriteLine($"나이: {age}");
}
