/*
Задача 2: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два
неотрицательных числа m и n.

Пример:

m = 2, n = 3 -> A(m,n) = 29
*/

Console.WriteLine("Введите натуральное число M: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите натуральное число N: ");
int n = Convert.ToInt32(Console.ReadLine());

int FunctionAkk(int m, int n)
{
    if (m == 0) return n + 1;
    else if (n == 0 && m > 0) return FunctionAkk(m - 1, 1);
    else return FunctionAkk(m - 1, FunctionAkk(m, n - 1));
}

Console.Write($"A(m,n) = {FunctionAkk(m, n)}");