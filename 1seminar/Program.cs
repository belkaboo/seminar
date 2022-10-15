// Домашнее задание, задача 2
Console.Clear();
Console.WriteLine("Введите 2 числа: ");
int NumberA = Convert.ToInt32(Console.ReadLine());
int NumberB = Convert.ToInt32(Console.ReadLine());

if (NumberA < NumberB)
{
    Console.WriteLine(NumberB);
    
}
if (NumberA == NumberB)
{
    Console.WriteLine("Числа равны");

}
else
{
    Console.WriteLine(NumberA);
}