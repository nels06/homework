//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

int GetSecondDigit(int num)
{
    int secondDigit = (num % 100) / 10;
    return secondDigit;
}


Console.Write("Введите трёхзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

int result = GetSecondDigit(number);

Console.WriteLine(result);