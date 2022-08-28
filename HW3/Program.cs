// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

bool CheckDay(int num)
{
    if (num == 6) return true;
    if (num == 7) return true;
    return false;
}

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (CheckDay(number))
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}