Console.WriteLine("ВВедите число дня недели: ");
int num1 = Convert.ToInt32(Console.ReadLine());

switch (num1)
{
    case 1:
        Console.WriteLine("Понедельник. Нет");
        break;
    case 2:
        Console.WriteLine("Вторник. Нет");
        break;
    case 3:
        Console.WriteLine("Среда. Нет");
        break;
    case 4:
        Console.WriteLine("Четверг. Нет");
        break;
    case 5:
        Console.WriteLine("Пятница. Нет");
        break;
    case 6:
        Console.WriteLine("Суббота. Да.");
        break;
    case 7:
        Console.WriteLine("Воскресенье. Да");
        break;
    default:
        Console.WriteLine("Нет такого дня");
        break;
}