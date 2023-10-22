// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int Sum(int number)
{
    int theLastDigit, sum = 0;

while (number != 0)
    {
        theLastDigit = number%10;
        sum = sum + theLastDigit;
        number = number / 10;
    }
    return sum;
}

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Сумма цифр: {Sum(num)}");

