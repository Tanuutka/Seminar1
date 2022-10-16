Console.WriteLine("Введите число: ");
int number = Convert.ToInt32 (Console.ReadLine());
Console.Clear();
int i = -2;
while (i < number-1)
{
    i+=2;

   Console.Write(" "+ i) ;
}