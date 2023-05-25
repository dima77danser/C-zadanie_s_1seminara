//Напишите программу, которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.WriteLine("ВВедите число:");
int num = Convert.ToInt32(Console.ReadLine());

int num2 = 1;

while (num >= num2)
{
   if (num2 % 2 == 0)
   {
    Console.Write(num2);
   } 
    num2++;
}
