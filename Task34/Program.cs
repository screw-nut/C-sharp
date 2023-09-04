//Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2

void ArrayRandom(int [] arr) //Заполнение массива
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(100, 1000);
    }
}

void PrintArray(int[] arr) 
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
    }
    Console.WriteLine();
}

int SearchEven (int[] arr) // происк кол-ва четных элементов
{
    int res = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0)
        {
        res++;
        }
    }
    return res;
}

Console.Write("Введите кол-во 3-х значных чисел в массиве: ");
int size = Convert.ToInt32(Console.ReadLine());

int [] array = new int[size];

ArrayRandom(array);
PrintArray(array);
int result = SearchEven(array);

Console.WriteLine($"В массиве {result} четных числа");
