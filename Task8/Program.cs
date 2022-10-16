// задача 8
Console.Clear();
Console.WriteLine("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());

// проверка числа
if (N < 2)
{
 Console.WriteLine("Введите число побольше: ");  
 N = Convert.ToInt32(Console.ReadLine()); 
}
// начало
int index = 1;
while (index < N)
{
    if (index % 2 == 0)
        {
        Console.Write($"{index}, ");
        index++;
        }
    else
    {
    index++;
    }
}
Console.Write(index);
