Console.WriteLine("Введите трёхзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
int digit2 = number /10 % 10;
Console.WriteLine($"Вторая цифра = {digit2}");