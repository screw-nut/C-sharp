// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

//Метод
int InputNumbers(string input)
{
    Console.Write(input);
    int output = Convert.ToInt32(Console.ReadLine());
    return output;
}
//Метод
void NaturalNamber(int n, int count)
{
    if (count <= n)
    {
        NaturalNamber(n, count + 1);
        Console.Write(count + " ");
    }
}

//Тело
Console.Clear();

int count = 1;
int n = 0;
n = InputNumbers("Введите число N: ");
while (n <= count)
{
    Console.WriteLine($"Недопустимый диапозон, введите натуральное число больше 1");
    n = InputNumbers("Введите число N: ");
}

NaturalNamber(n, count);



