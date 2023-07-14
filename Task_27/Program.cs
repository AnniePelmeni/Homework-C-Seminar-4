// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

void ShowSum(int number)
{
    int sum = 0;
    while (number > 0)
    {
        sum = sum + number%10;
        number = number / 10;
    }
    Console.WriteLine($"Сумма цифр равна {sum}");
}


int GetInput(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int number = GetInput ("Введите число: ");

ShowSum(number);