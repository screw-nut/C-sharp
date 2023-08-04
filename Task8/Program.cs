// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int count = 1;
while (count < number)
{
    if(number % 2 == 0)
    {
        Console.Write(number + "  ");
        number = number - 1;
    }
    else 
    {
        number = number - 1;
    }
}
