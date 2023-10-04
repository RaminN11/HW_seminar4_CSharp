// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12


int number = ReadInt("Введите число: ");
int ReadInt(string message)
{
    Console.WriteLine(message);
    return int.Parse(Console.ReadLine()!);
}

int length = NumberLength(number);
int NumberLength(int num1)
{
    int i = 0;
    while (num1 > 0)
    {
        num1 = num1 / 10;
        i++;
    }
    return i;
}

SumNumbers(number, length);
void SumNumbers(int num2, int length)
{
    int sum = 0;
    for (int i = 0; i <= length; i++)
    {
        sum = sum + num2 % 10;
        num2 = num2 / 10;
    }
    Console.WriteLine(sum);
}