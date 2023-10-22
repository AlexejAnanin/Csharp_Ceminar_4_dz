// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

// Задача 29: Напишите программу, которая задаёт массив
// из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int[] WritingArray(int length, int min, int max)
{
    int[] array = new int[length];
    Random randomNumber = new Random();
    for (int i = 0; i < length; i++)
    {
        array[i] = randomNumber.Next(min, max + 1);
    }
    return array;
}

void printArray(int[] array)
{
    int length =array.Length;
    Console.Write($"[");
    for (int i = 0; i < length - 1; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.Write($"{array[length - 1]}]");
}

Console.Write("Введите длину массива: ");
int length = Convert.ToInt32(Console.ReadLine());
Console.Write("Нижнюю границу случайных чисел: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Верхнюю границу случайных чисел: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] arr = WritingArray(length, min, max);
printArray(arr);