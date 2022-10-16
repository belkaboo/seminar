// Задача 4
Console.Clear();

Console.WriteLine("Введите числа: ");
int NumberA = Convert.ToInt32(Console.ReadLine());
int NumberB = Convert.ToInt32(Console.ReadLine());
int NumberC = Convert.ToInt32(Console.ReadLine());

int max = NumberA;
if (NumberB > max)
    {
        max = NumberB;
    }
if (NumberC > max)
    {
        max = NumberC;
    }
Console.WriteLine ($"Большее число = {max}");

