// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32 (Console.ReadLine());
Console.Clear();
int i = 0;
while (i < number-1)
{
    i+=2;

   Console.Write(" "+ i) ;
}