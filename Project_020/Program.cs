// Задача 20: Задать номер четверти, показать диапазоны для возможных координат

int x = new Random().Next(1, 5);
Console.WriteLine(x);


if (x == 1)
    Console.WriteLine("Четверть I:  X=(0, +oo)  Y=(0, +oo)");
if (x == 2)
    Console.WriteLine("Четверть II:  X=(-oo, 0)  Y=(0, +oo)");
if (x == 3)
    Console.WriteLine("Четверть III:  X=(-oo, 0)  Y=(-oo, 0)");
if (x == 4)
    Console.WriteLine("Четверть IV:  X=(0, +oo)  Y=(-oo, 0)");
