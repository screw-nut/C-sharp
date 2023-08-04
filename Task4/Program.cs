// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22
Console.Write("Введите первое число: ");
int number_1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int number_2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число: ");
int number_3 = Convert.ToInt32(Console.ReadLine());
int max;
if (number_1 > number_2)
{
    max = number_1;
}
else
{
    max = number_2;
}
if (max > number_3)
{
    Console.Write("Большее число = ");
    Console.WriteLine(max);
}
else
{
    Console.Write("Большее число = ");
    Console.WriteLine(number_3);
}