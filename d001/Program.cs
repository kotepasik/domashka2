// 1. Напишите программу, которая на вход принимает два чила и выдаёт, какое число большее, а какое меньшее


int n = new Random().Next(0, 100);
int m = new Random().Next(0, 100);

Console.WriteLine($"Сравниваем число {n} с числом {m}");

if (n > m)
{
    Console.WriteLine($"Число {n} большее, а число {m} меньшее");
}
else
{
    Console.WriteLine($"Число {m} большее, а  число {n} меньшее");
}


// 2. Напишите программу, колторая принимает на вход три числа и выдаёт максимальное из этих чисел

/*
int a = new Random().Next(0, 100);
int b = new Random().Next(0, 100);
int c = new Random().Next(0, 100);
int max = a;
Console.WriteLine($"Сравниваем числa {a}, {b}, {c}");

if (b > a)
{
    max = b;
}

if (c > max)
{
    max = c;
}

Console.WriteLine($"Максимальное из них: {max}");
*/

// 3. Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка)

/*
int a = new Random().Next(0, 100);
Console.WriteLine(a);
if (a % 2 == 0)
{
    Console.WriteLine("Число является чётным");
}
else
{
    Console.WriteLine("Число является нечётным");
}
*/

// 4. Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N

/*
Console.Write("Введите число: ");
int n = int.Parse(Console.ReadLine());
for (int i = 2; i <= n; i += 2)
    Console.WriteLine(i);
*/