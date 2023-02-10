// Задача №3. Напишите программу, которая будет выдавать название дня недели по заданному номеру.
// 3 -> Среда
// 5 -> Пятница

void weekDays(int a)
{
    var days = new Dictionary<int, string>()
    {
        {1,"Понедельник"},
        {2,"Вторник"},
        {3,"Среда"},
        {4,"Четверг"},
        {5,"Пятница"},
        {6,"Суббота"},
        {7,"Воскресенье"}
    };
    foreach (var day in days)
    {
        if (day.Key == a) Console.WriteLine(day.Value);
    }
}

weekDays(1);
weekDays(7);
weekDays(5);