//Console.Clear();
//Console.Write("Введите номер дня недели: ");
//int day = int.Parse(Console.ReadLine());
//if (day == 1)
   // {
  //  Console.Write("Это Понедельник");
   // }
//if (day==2)
 //   {
   // Console.Write("Это Вторник");
    //}
//if (day==3)
  //  {
    //    Console.Write("Это Среда");
   // }
//if (day == 4)
  //  {
    //    Console.Write("Это Четверг");
   // }
//if (day==5)
  //  {
   // Console.Write("Это Пятница");
   // }
//if (day==6)
  //  {
    //    Console.Write("Это Суббота");
   // }
//if(day==7)
  //  {
    //    Console.Write("Это Воскресенье");
   // }
//else if (day > 7 || day < 1)
  //  {
    //    Console.Write("$Ошибка: введено неправильное значение");
   // }
// using System;
class Program
{
    static void Main()
    {
        // Очистка консоли
        Console.Clear();
        
        // Запрашиваем ввод номера дня недели
        Console.Write("Введите номер дня недели: ");
        int day = int.Parse(Console.ReadLine());

        // Используем switch для выбора соответствующего дня недели
        switch (day)
        {
            case 1:
                Console.WriteLine("Это Понедельник");
                break;
            case 2:
                Console.WriteLine("Это Вторник");
                break;
            case 3:
                Console.WriteLine("Это Среда");
                break;
            case 4:
                Console.WriteLine("Это Четверг");
                break;
            case 5:
                Console.WriteLine("Это Пятница");
                break;
            case 6:
                Console.WriteLine("Это Суббота");
                break;
            case 7:
                Console.WriteLine("Это Воскресенье");
                break;
            default:
                Console.WriteLine("Ошибка: введено неправильное значение.");
                break;
        }
    }
}
