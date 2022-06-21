// Напишите программу, которая на вход принимает два числа и выдаёт, 
// какое число большее, а какое меньшее.
// 
Console.WriteLine("Введите первое число => ");
string param = Console.ReadLine(); 
int a = int.Parse(param); 
Console.WriteLine("Введите второе число =>"); 
string param2 = Console.ReadLine(); 
int b = int.Parse(param2); 
if (a < b)
{
        Console.WriteLine($"min={a} и max={b}");
}
else if (a > b)
{
        Console.WriteLine($"min={b} и max={a}");
}
else 
{
    Console.WriteLine("числа равны");
}