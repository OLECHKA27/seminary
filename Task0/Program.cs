// Написать программу на вводе число на выводе квадрат числа
//Console.WriteLine ($"Квадрат числа A = {KV}");


Console.Clear();
Console.Write("Введите число: ");
int number=int.Parse(Console.ReadLine());
//int SQ =number*number;
int SQ = Convert.ToInt32(Math.Pow(number, 2));
Console.WriteLine ($"Квадрат числа A = {SQ}");