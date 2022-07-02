// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет,
//  является ли этот день выходным.


Console.Write("Введите порядковый номер дня недели от 1 до 7: ");
Console.WriteLine();
int numberWeekday = Convert.ToInt32(Console.ReadLine());

while (numberWeekday < 8)
{
    if (numberWeekday <= 5)
    {
        Console.Write(" - это рабочий день недели.");
        break;
    }
    else
    {
        if (numberWeekday >= 6)
        {
            Console.Write("- это выходной день недели.");
            break;
        };
    }
}

