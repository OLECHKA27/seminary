Console.Clear();
Console.Write("Введите число N: ");
int N= int.Parse(Console.ReadLine());
if (N>0)
{
    Console.Write($"Число N= {N} Положительное ");
}
else if (N<0)
{
    Console.Write($"Число N= {N} Отрицательное ");
}
else
Console.Write($"Число N : *{N}* ");