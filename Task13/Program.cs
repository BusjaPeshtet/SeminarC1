Console.Clear(); //Дано число из отрезка [10, 99]. Показать наибольшую цифру числа  
Console.WriteLine();
int number = new Random().Next(10, 100);
Console.WriteLine($"{number}");
int firstdigital = number / 10;
Console.WriteLine($"{firstdigital}");
int seconddigital = number % 10;
Console.WriteLine($"{seconddigital}");
if (firstdigital > seconddigital)
{
    Console.WriteLine($"{firstdigital} это наибольшая цифра числа");
}
else
{
    Console.WriteLine($"{seconddigital} это наибольшая цифра числа");
}
