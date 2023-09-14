// Метод заполнения массива случайными вещественными числами в диапозоне от min до max
int[,] CreateIncreasingMatrix(int n, int m, int k)
{
    int[,] array = new int [n, m];
    int step = 1;
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
            array[i, j] = step;
            step = step + k;
        }
        
    }
    return array;
}

// Печать массива array
void PrintArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} \t");
        }
        Console.WriteLine("");
    }
}

// Проверяем диапозон массива. выходит за пределы или нет
int[] FindNumberByPosition (int [,] matrix, int rowPosition, int columnPosition)
{
    int [] arr = new int[2];
    if (matrix.GetLength(0) < rowPosition  || matrix.GetLength(1) < columnPosition )
    {
        arr[0] = 0; arr[1] = 0;
        return arr;
    }
    else {
        arr[0] = matrix[rowPosition-1, columnPosition-1]; arr[1] = 0;
        return arr;
    }
}

// Печать позиции
void PrintCheckIfError (int[] results, int X, int Y)
{
    if(results[0] == 0) 
    {
       Console.WriteLine("There is no such index"); 
    }
    else {
        Console.WriteLine($"The number in [{X}, {Y}] is {results[0]}");
    }
}


int n = 3;
int m = 4;
int k = 2;
int x = 8;
int y = 3;
int[,] result = CreateIncreasingMatrix(n, m, k);
PrintArray(result);
PrintCheckIfError(FindNumberByPosition(result, x, y), x, y);