// Задача 6: Напишите программу, которая на вход принимает число и выдает, является ли число четным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет

void evenNumber(int a)
{
    if (a % 2 == 0) Console.WriteLine($"{a} -> да ");
    else Console.WriteLine($"{a} -> нет");
}

evenNumber(-4);
evenNumber(-3);
evenNumber(7);
