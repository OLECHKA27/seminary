Console.Clear();
Console.Write("Введите трехзначное число N: ");
int N = int.Parse(Console.ReadLine());
//int a=N/100;
//int b= (N/10)%10;
int c=N%10;
Console.WriteLine($"Последняя цифра трехзначного числа {N}: {c}");
//for (int i = 1; i<=9; i++)
//if (a % i == 0 || b % i == 0 || c % i == 0)
//{
    Console.Write(c);
//}

//Console.WriteLine("Однозначные делители числа {0}:", N);

//for (int i = 1; i<=9; i++)
//if (N%i==0)
//{
   // Console.Write(i);
//}