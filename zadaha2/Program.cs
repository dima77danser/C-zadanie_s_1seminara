//  Напишите программу, которая на вход принимает два числа и выдаёт,
// какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.WriteLine("ВВедите число:");
int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("ВВедите число:");
int num2 = Convert.ToInt32(Console.ReadLine());

if (num > num2)
{
   Console.Write("max:");
   Console.WriteLine(num);
}
else
{
    Console.Write("max:");
    Console.WriteLine(num2);
}