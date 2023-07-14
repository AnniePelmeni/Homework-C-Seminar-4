// Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16


void RaiseToAPower(int number1, int number2)
{
    int temp = number1;
    int number3 = number1;
    for(int count = 1; count < number2; count++) 
    {
        number3 = number3 * temp;
    }
    Console.WriteLine($"Число {number1} в степени {number2} равно {number3}");
}

int GetInput(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int number1 = GetInput ("Введите первое натуральное число: ");
int number2 = GetInput ("Введите второе натуральное число: ");

RaiseToAPower(number1, number2);
