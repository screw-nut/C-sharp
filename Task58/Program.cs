//Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
//Например, даны 2 матрицы:
//2 4 | 3 4
//3 2 | 3 3
//Результирующая матрица будет:
//18 20
//15 18

//Методы

//ввод целого числа
int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

// Заполнение массива случайными числами от 1 до 99
void FillArrayRandom(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 100);
        }
    }
}

// Вывод массива 
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} \t");
        }
        Console.WriteLine("");
    }
}




//Тело

Console.WriteLine("Чтобы посчитать произведение массива, кол-во столбцов одного массива должно быть равно кол-ву строк второго массива");
int rows1 = ReadInt("Введите количество строк первого массива: ");
int columns1 = ReadInt("Введите количество столбцов первого массива: ");
int[,] array1 = new int[rows1, columns1];
int rows2 = ReadInt("Введите количество строк второго массива: ");
int columns2 = ReadInt("Введите количество столбцов второго массива: ");
int[,] array2 = new int[rows2, columns2];
int[,] resultArray = new int[rows1,columns1];


FillArrayRandom(array1);
FillArrayRandom(array2);
Console.WriteLine("");
PrintArray(array1);
Console.WriteLine("*");
PrintArray(array2);
Console.WriteLine("=");

//Произведение и проверка 2-х массивов
if (array1.GetLength(0) != array2.GetLength(1))
{
    Console.WriteLine(" Нельзя перемножить массивы ");
    return;
}
for (int i = 0; i < array1.GetLength(0); i++)
{
    for (int j = 0; j < array2.GetLength(1); j++)
    {
        resultArray[i, j] = 0;
        for (int k = 0; k < array1.GetLength(1); k++)
        {
            resultArray[i, j] += array1[i, k] * array2[k, j];
        }
    }
}



PrintArray(resultArray);




