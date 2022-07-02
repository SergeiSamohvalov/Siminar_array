// //  Напишите программу, которая принимает на вход трёхзначное число и на выходе
//  показывает вторую цифру этого числа.

// Этот метод заполняет массив случайными числами
void FillArray(int[] number)

{
    int length = number.Length;
    int index = 0;
    while (index < length)
    {
        number[index] = new Random().Next(1,3);
        index++;
    }
}
// Этот метод печатет массив
void Printarray(int[] mass)
{
    int count = mass.Length;
    int index = 0;
    while (index < count)
    {
        Console.Write(mass[index].ToString());
        index++;
    }
}

int[] array = new int[3];

FillArray(array);
Printarray(array);

Console.WriteLine();

// Выводим второй элемент на печать
Console.Write(array[1]);
