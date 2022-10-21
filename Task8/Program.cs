// задача 8 четные от 1 до N
Console.Clear();
Console.WriteLine("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());

// проверка числа для работы цикла
if (N <= 2)
{
 Console.WriteLine("Введите число побольше: ");  
 N = Convert.ToInt32(Console.ReadLine()); 
}

int index = 1;
while (index < N)
{
    if (index % 2 == 0)
        {
        Console.Write($"{index} ");
        index++;
        }
    else
    {
    index++;
    }
}


