Console.Clear(); //Показать последнюю цифру трёхзначного числа 
Console.WriteLine();
int number = new Random().Next(100, 1000);
Console.WriteLine($"Последней цифрой числа {number} является цифра {number%10}");
Console.WriteLine();
