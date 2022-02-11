// Задача 18: Проверить истинность утверждения    ¬(X ⋁ Y) = ¬X ⋀ ¬Y
// ¬ - знак отрицания
// ⋀ - логическое "И"
// ⋁ - логическое "ИЛИ"
// следовательно не (X или Y) = не X и не Y

bool x = true;
bool y = true;

if (!(x || y) == (!x && !y))
    Console.WriteLine($"Вар. 1 утверждение истинно при x = true y = true");
else
    Console.WriteLine($"Вар. 1 утверждение не истинно при x = true y = true");

x = true;
y = false;

if (!(x || y) == (!x && !y))
    Console.WriteLine($"Вар. 2 утверждение истинно при x = true y = false");
else
    Console.WriteLine($"Вар. 2 утверждение не истинно при x = true y = false");

x = false;
y = true;

if (!(x || y) == (!x && !y))
    Console.WriteLine($"Вар. 3 утверждение истинно при x = false y = true");
else
    Console.WriteLine($"Вар. 3 утверждение не истинно при x = false y = true");

x = false;
y = false;

if (!(x || y) == (!x && !y))
    Console.WriteLine($"Вар. 4 утверждение истинно при x = false y = false");
else
    Console.WriteLine($"Вар. 4 утверждение не истинно при x = false y = false");