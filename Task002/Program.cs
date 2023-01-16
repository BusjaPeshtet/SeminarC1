Console.Clear(); //По двум заданным числам проверять является ли первое квадратом второго
Console.WriteLine("Введите число А:");
int numberA = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число B:");
int numberB = int.Parse(Console.ReadLine());
if (numberA == numberB*numberB)
{
    Console.WriteLine("Все верно");
}
else
{
    Console.WriteLine($"{numberA} не является квадратом числа {numberB}");
}