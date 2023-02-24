// 1. Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

/*
Console.Write("Введите первое число: ");

int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");

int b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(a > b ? "Первое число больше второго" : "Второе число больше первого");
*/

// 2.  Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел
/*
Console.Write("Введите первое число: ");

int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");

int b = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите третье число: ");

int c = Convert.ToInt32(Console.ReadLine());

int max = Math.Max(a, Math.Max(b, c));
Console.WriteLine("Максимальное число: " + max); 
*/

// 3. Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
/*
Console.Write("Введите число: ");

int a = Convert.ToInt32(Console.ReadLine());

if (a % 2 == 0)
    Console.WriteLine("Это чётное число");
else
    Console.WriteLine("Это Нечётное число");
    */

// 4. Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
/*
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i <= n; i++)
    if (i % 2 == 0)
        Console.Write("," + i);
        */