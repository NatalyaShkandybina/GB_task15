Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
number = Math.Abs(number);

if(number<100)
{
    Console.WriteLine("Третьей цифры нет");
}
// if(number > 99 && number <1000)
// {
//     Console.WriteLine(number % 10);
// }
else{
    string nuber1 = number.ToString();
    Console.WriteLine(nuber1[2]);
}