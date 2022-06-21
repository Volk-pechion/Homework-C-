// Напишите программу, которая на вход принимает число и выдаёт,
// является ли число чётным (делится ли оно на два без остатка).

Console.WriteLine("Введите число => ");
string param = Console.ReadLine(); 
int a = int.Parse(param); 

if (a%2==0)
{
        Console.WriteLine($"число четное");
}
else 
{
    Console.WriteLine("число не четное");
}