// // Задача 1: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N. Использовать рекурсию, не использовать циклы.
// Console.Clear();
// Console.WriteLine("Введите начальное значение");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите конечное значение значение");
// int n = Convert.ToInt32(Console.ReadLine());

// string res(int n)
// {
//     if (n <= m)
//     {
//         return $"{m}";
//     }
//     return res(n - 1) + $" {n}";
// }

// Console.WriteLine($"M = {m}; N = {n} -> {res(n)}");

void dont() // метод проверки на положительные значения
{
    Console.Clear();
    Console.WriteLine("Значения должны быть положительными!");
}

int A(int n, int m) // метод работы функции Аккермана
{

    if (n == 0)
        return m + 1;
    if (m == 0)
        return A(n - 1, 1);
    return A(n - 1, A(n, m - 1));
}

Console.Clear();
Console.Write("Введите значения m и n (m >= 0 и n >= 0):\nm= ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значения m и n (m >= 0 и n >= 0):\nn= ");
int n = Convert.ToInt32(Console.ReadLine());

if (n < 0 || m < 0) // проверка на отрицательные значния
{
    dont();
}
else
{
    Console.Clear();
    Console.WriteLine($"m = {m}, n = {n}, A(m, n) = {A(m, n)}");
}