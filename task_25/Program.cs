// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

// Задача 25: Напишите цикл, который принимает на вход
// два числа (A и B) и возводит число A в натуральную
// степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

 static int RaisingToPower(int A, int B)
 {
       int result = 1;

for (int i = 1; i <= B; i++)
    {
         result = result * A;
    }

    return result;
 };


Console.Write("Введите число: ");
int A = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите степень: ");
int B = Convert.ToInt32(Console.ReadLine());

if (B <= 0) Console.WriteLine($"Степень {B} не натуральная!");
    else
    {
    int res = RaisingToPower(A, B);

    Console.WriteLine($"{res}");
    };

