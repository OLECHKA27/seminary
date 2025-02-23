Console.Clear();
Console.Write("Введите первое число A1:");
int A1 =int.Parse(Console.ReadLine());
Console.Write("Введите второе число A2:");
int A2 =int.Parse(Console.ReadLine());
Console.Write("Введите третье число A3:");
int A3 =int.Parse(Console.ReadLine());

// Определяем среднее число
 //if ((A1 > A2 && A1 < A3) || (A1 < A2 && A1 > A3))
//Console.WriteLine($"Среднее число A = {A1}");
//else if ((A2 > A1 && A2 < A3) || (A2 < A1 && A2 > A3))
//Console.WriteLine($"Среднее число A = {A2}");
//else if ((A3 > A1 && A3 < A2) || (A3 < A1 && A3 > A2))
//Console.WriteLine($"Среднее число A = {A3}");
 //else if (A1 == A2 || A1 == A3 || A2 == A3) // Два числа равны
 //Console.WriteLine("Два числа равны, среднее выбрать невозможно.");
 //else
//Console.WriteLine("Все числа равны.");
// Массив из трех чисел
int[] numbers = { A1, A2, A3 };

// Сортируем
Array.Sort(numbers);
if (A1 == A2 || A1 == A3 || A2 == A3) // Два числа равны
 Console.WriteLine("Два числа равны, среднее выбрать невозможно.");

// Среднее число будет вторым элементом отсортированного массива
else 
Console.WriteLine($"Среднее число A = {numbers[1]}");