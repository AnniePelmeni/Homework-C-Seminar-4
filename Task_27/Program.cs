// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

void ShowSum(int number)
{
    int sum = 0;
    int temp = number;
    while (temp > 0)
    {
        sum = sum + temp % 10;
        temp = temp / 10;
    }
    Console.WriteLine($"Сумма цифр числа {number} равна {sum}");
}

int GetInput(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int number = GetInput ("Введите число: ");

ShowSum(number);