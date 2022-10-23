// Напишите программу, которая принимает на вход число (N) и выдает
// таблицу кубов чисел от 1 до N.
// 3 -> 1,8,27
// 3 -> 1,4,9
// 5 -> 1,8,27,64,125

Console.Clear();

void Kub (int n)
{
    for (int i = 1; i <= n; i++)
    {
        Console.Write($"{i*i*i}");
        if (i !=n)
        {
            Console.Write(", ");
        }
    }
}

Console.Write("Введите число: ");
int N = int.Parse(Console.ReadLine()!);
Kub (N);
