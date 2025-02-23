internal class Program
{
    private static void Main(string[] args)
    {
        Console.Clear();
        Console.Write("Введите число N: ");
        int N = int.Parse(Console.ReadLine());
        int A = 1;
        if (N < 1)
        {
            Console.Write("N Должно быть более или равно 1");
        }
        else
            while (A <= N)
            {
                Console.Write($" {A} ");
                A = A + 2;
            }
    }
}