Console.Clear();
Console.Write("Введите число A:");
int A =int.Parse(Console.ReadLine());

Console.Write("Введите число B: ");
int B =int.Parse(Console.ReadLine());

//if (A == B*B)
//if (B==A/B)
if (Math.Pow(B, 2)==A)
{Console.Write("Да");}
else
{Console.Write("Нет");}