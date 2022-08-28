//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

int GetThirdDigit(int num)
{
    while (num > 999)
    {
        num = num / 10;
    }
    int third = num % 10;
    return third;
}


Console.Write("Введите число: ");
string number = Console.ReadLine();

if (number.Length > 2)
{
    int result = GetThirdDigit(Convert.ToInt32(number));
    Console.WriteLine(result);
}
else
{
    Console.WriteLine("Третьей цифры нет");
}


