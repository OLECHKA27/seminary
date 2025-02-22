Console.Clear();
Console.Write("Введите число N: ");
int N = int.Parse(Console.ReadLine());
int A = -N;
while (A<=N)
{
    Console.Write($" {A}");
    A++;
}

