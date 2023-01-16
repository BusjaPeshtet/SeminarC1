 Console.Clear(); //Показать четные числа от 1 до N

Console.Write("Input number N : ");
int N = int.Parse(Console.ReadLine()) ; 
int Y = 2;
Console.WriteLine("All equal numbers before N are : ") ;
while (Y <= N)  
{
    Console.WriteLine(Y);

 Y = Y+2;
}
