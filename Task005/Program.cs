Console.Clear(); //Выяснить является ли число чётным
Console.WriteLine("Input number1 : ");
int number1 = int.Parse(Console.ReadLine()) ; 
if (number1%2 == 0)
    Console.WriteLine("Number1 is even");
    else
    Console.WriteLine("Number1 is not even"); 
