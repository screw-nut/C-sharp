// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

//Метод Ввод числа
int InputNumbers(string input)
{
    Console.Write(input);
    int output = Convert.ToInt32(Console.ReadLine());
    return output;
}
//Метод Сумма натуральных от M до N.
int NaturalSum(int min, int max)
{
    int sum = 0;
    if(min != max)
    {
    min++;
    sum = min + NaturalSum(min , max);
    
    return sum;
    }
    return 0;
}

//Тело
//Console.Clear();
int m = InputNumbers("Введите число M: ");
int n = InputNumbers("Введите число N: ");

if (m > n)
{
    int tmp = n; n = m; m = tmp;
}

Console.Write(NaturalSum(m-1, n));
