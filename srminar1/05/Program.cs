// Домашняя работа

// Задача 2: Напишите программу, которая на вход принимает два числа и выдает, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7, min = 5
// a = 2 b = 10 -> max = 10, min = 2
// a = -9 b = -3 -> max = -3, min = -9

void maxMin(int a, int b)
{
    if (a > b) Console.WriteLine($"{a} > {b} -> max = {a} min = {b}");
    else Console.WriteLine($"{b} > {a} -> max = {b} min = {a}");
}

maxMin(5, 7);
maxMin(2, 10);
maxMin(-9, -3);
