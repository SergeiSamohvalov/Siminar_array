// Напишите программу, которая выводит третью цифру заданного числа или сообщает,
//  что третьей цифры нет.

//Создание объекта для генерации чисел
Random rnd = new Random();
//Получить случайное число (в диапазоне от 10 до 1000)
int value = rnd.Next(2, 5);
//Вывод числа в консоль
Console.WriteLine(value);

// Создаем массив размером - случайным образом сгенерированное число
int[] array = new int[value];

// Этот метод заполняет массив случайными числами
void FillArray(int[] number)

{
    int length = number.Length;
    int index = 0;
    while (index < length)
    {
        number[index] = new Random().Next(1, value);
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

FillArray(array);
Printarray(array);

int length = array.Length;
int position = 0;
while (position < length);
{
    if (length >= 2);
    Console.WriteLine(array[2].ToString());
    position++;
}
        if (length < 2);
        {
           Console.WriteLine("- третьей цифры нет"); 
        }
