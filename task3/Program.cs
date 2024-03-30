/*
Задача 3: Задайте произвольный массив. Выведете его элементы, начиная с конца. Использовать
рекурсию, не использовать циклы.

Пример:

[1, 2, 5, 0, 10, 34] => 34 10 0 5 2 1
*/

int[] array = { 1, 2, 5, 0, 10, 34 };

string PrintArray(int[] array)
{
    return string.Join(", ", array);
}
int[] ArraySwap(int[] array, int index)
{

    if (index <= 0)
    {
        return array;
    }
    int temp = array[index];
    array[index] = array[array.Length - index - 1];
    array[array.Length - index - 1] = temp;
    return ArraySwap(array, index -= 2);
}

Console.WriteLine($"{PrintArray(ArraySwap(array, array.Length - 1))}");
