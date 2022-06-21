// Напишите программу, которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N.

Console.WriteLine("Введите число: ");
string param = Console.ReadLine(); 
int N = int.Parse(param); 

 if (N > 1)
 {
     int a = 2;
     while (a <= N)
     {
         if (a == N || a + 1 == N) 
         {
             Console.Write($"{a}");
             break;
         }
         Console.Write($"{a}, ");
         a = a + 2;
     }
 }
 else
{ 
     int a = 0;
     while (a >= N)
     {
         if (a == N || a - 1 == N)
         {
             Console.Write($"{a}");
             break;
         }
         Console.Write($"{a}, ");
         a = a - 2;

     }
}
