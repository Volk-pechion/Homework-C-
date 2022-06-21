//Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.WriteLine("Введите первое число => ");
string param = Console.ReadLine(); 
int a = int.Parse(param); 
Console.WriteLine("Введите второе число =>"); 
string param2 = Console.ReadLine();
int b = int.Parse(param2); 
Console.WriteLine("Введите третье число =>"); 
string param3 = Console.ReadLine();
int c = int.Parse(param3); 
if ((a < b) && (c < b))
{
        Console.WriteLine($"max={b}");
}
else if ((a < c) && (b < c))
{
        Console.WriteLine($"max={c}");
}
else 
{
    Console.WriteLine($"max={a}");
}
