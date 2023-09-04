// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0


int size = Read("Введите размер массива: ");
int min = Read("Введите минимальное число массива: ");
int max = Read("Введите максимальное число массива: ");


int [] array = new int[size];

ArrayRandom(array);
PrintArray(array);
int result = SumOddPos(array);
Console.WriteLine(result);

//Функции

void ArrayRandom(int [] arr) //Заполнение массива
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(min, max);
    }
}

void PrintArray(int[] arr) // вывод на экран сгенерированного массива
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

int SumOddPos(int[] arr)
{
    int sum = 0;
    for (int i=1; i < arr.Length; i+=2)
    {
        sum = sum + arr[i];        
    }
    return sum;
}