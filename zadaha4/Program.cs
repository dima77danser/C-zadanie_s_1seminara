// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.WriteLine("ВВедите число:");
int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("ВВедите число:");
int num2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("ВВедите число:");
int num3 = Convert.ToInt32(Console.ReadLine());

int max = num;

if (num2 > max)
{
    max = num2;
}
if (num3 > max)
{
    max = num3;
}

Console.Write("max:");
Console.WriteLine(max);