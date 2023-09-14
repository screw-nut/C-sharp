// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

int size = Read("Введите размер массива: ");
int min = Read("Введите минимальное число массива: ");
int max = Read("Введите максимальное число массива: ");


double [] array = new double[size];

ArrayRandom(array);
PrintArray(array);

double result = differenceMinMax(array);
Console.WriteLine(result);


//Функции

void ArrayRandom(double[] arr) //Заполнение массива
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(min, max);
    }
}

void PrintArray(double[] arr) // вывод на экран сгенерированного массива
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
    }
    Console.WriteLine();
}

int Read(string message)  
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int differenceMinMax(int[] arr)
{
    double max = arr[0];
    double min = arr[0];
    double res = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > max)
        {
            max = arr[i];
        }
        if (arr[i] < min)
        {
            min = arr[i];
        }
    }
    res = max - min;
    Console.Write(max + "-" + min + "=");
    return res; 
}