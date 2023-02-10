// Задача 4: Напишите программу, которая принимает на вход
// три числа и выдает максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

void maximum(int a, int b, int c)
{
    int[] x = { a, b, c };
    int maximum = a;
    foreach (int maxi in x) if (maxi > maximum) maximum = maxi;
    Console.WriteLine($"max = {maximum}");
}

maximum(2, 3, 7);
maximum(44, 5, 78);
maximum(22, 3, 9);