/* Задача 38: Задайте массив натуральных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76 */

int[] GetRandomArray(int size, int leftRange, int rightRange)
{
    int[] array = new int[size];

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(leftRange, rightRange);
    }
    return array;
}

const int SIZE = 5;
const int LEFT = 0;
const int RIGHT = 100;

int[] massive = GetRandomArray(SIZE, LEFT, RIGHT);
Console.WriteLine(string.Join(", ", massive));

// Поиск максимального значения:
int MaxElement(int[] array)
{
    int max = massive[0];
    for(int i = 1; i < array.Length; i++)
    {
    if(array[i] > max) max = array[i];
    }
    return max;
}

// Поиск минимального значения:
int MinElement(int[] array)
{
    int min = massive[0];
    for(int i = 1; i < massive.Length; i++)
    {
    if(massive[i] < min) min = massive[i];
    }
    return min;
}

Console.WriteLine($"Максимальный элемент массива: {MaxElement(array: massive)}");
Console.WriteLine($"Минимальный элемент массива: {MinElement(array: massive)}");

int sum = MaxElement(massive) - MinElement(massive);
Console.WriteLine($"Разница между максимальным и минимальным элементов массива: {sum}");