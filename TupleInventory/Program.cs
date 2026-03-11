using System;
using System.Collections.Generic;

List<(string name, int quantity, int price)> inventory = new();


AddItem(inventory, "체력 포션", 3, 500);
AddItem(inventory, "마나 포션", 5, 800);
AddItem(inventory, "해독제", 2, 300);
AddItem(inventory, "엘릭서", 1, 5000);

(string expensiveName, int expensivePrice) = FindMostExpensive(inventory);
(int totalValue, int totalCount) = CalculateTotal(inventory);

Console.WriteLine("=== 아이템 인벤토리 ===");
foreach(var item in inventory)
{
    Console.WriteLine($"{item.name} - 수량: {item.quantity}개, 단가: {item.price}원");
}
Console.WriteLine();
Console.WriteLine("=== 가장 비싼 아이템 ===");
Console.WriteLine($"이름: {expensiveName}, 단가: {expensivePrice}");
Console.WriteLine();
Console.WriteLine("=== 인벤토리 합산 ===");
Console.WriteLine($"총 가치: {totalValue:N0}원\n총 아이템 수: {totalCount}개");
static void AddItem(List<(string name, int quantity, int price)> inventory, string name, int quantity, int price)
{
    inventory.Add((name, quantity, price));
}

static (string name, int price) FindMostExpensive(List<(string name, int quantity, int price)> inventory)
{
    string name ="";
    int expensive = -1;
    foreach(var item in inventory)
    {
        if(item.price > expensive) { name = item.name; expensive = item.price; }
    }
    return (name, expensive);
}

static (int totalValue, int totalCount) CalculateTotal(List<(string name, int quantity, int price)> inventory)
{
    int sum = 0;
    int count = 0;
    foreach( var item in inventory)
    {
        sum += item.price * item.quantity;
        count += item.quantity;
    }
    return (sum, count);
}