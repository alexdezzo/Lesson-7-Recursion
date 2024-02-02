// Задача 1: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N. Использовать рекурсию, не использовать циклы.
Console.Clear();
Console.WriteLine("Введите начальное значение");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите конечное значение значение");
int n = Convert.ToInt32(Console.ReadLine());

string res(int n)
{
    if (n <= m)
    {
        return $"{m}";
    }
    return res(n - 1) + $" {n}";
}

Console.WriteLine($"M = {m}; N = {n} -> {res(n)}");

