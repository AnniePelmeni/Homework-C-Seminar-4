// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

// Вариант1
// void PrintArray(int[] array)
// {
//     for(int i = 0; i < array.Length; i++)
//     {
//     array[i] = new Random().Next(1, 100);
//     Console.Write($"{array[i]} ");
//     }
// }

// int [] array = new int[8];
// PrintArray(array);


// Вариант2
void FillArray(int[] array)
{
    for(int i = 0; i < 8; i++)
    {
    Console.WriteLine("Введите число: ");
    array[i] = Convert.ToInt32(Console.ReadLine());
    }
}

int [] array = new int[8];
FillArray(array);
string str = string.Join(" ", array);
Console.WriteLine(str);
