Console.Clear();
Console.Write("Введите число N: ");
int N = int.Parse(Console.ReadLine());

Console.Write("Введите число M: ");
int M = int.Parse(Console.ReadLine());
if (M==0)
{
  Console.WriteLine("Ошибка! Делить на ноль нельзя.");
}

else if (N%M == 0)
{
Console.Write($"{N} делится на {M}");
}
else 
{
 Console.Write($"{N} не делится на {M}");   
}
