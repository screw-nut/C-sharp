int rows = 10;
int cols = 10; 

int min = -10;
int max = 10;

 double [,] array = FillMatrix(rows,cols);
PrintArray(array);
 
 // Методы
 
 // Метод заполнения массива случайными вещественными числами в диапозоне от min до max
double[,] FillMatrix(int rows, int cols)
{
    double [,] array = new double[rows, cols];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            array[i, j] = Math.Round(new Random().Next(min*10, max*10)*0.1, 1);
        }
    }
    return array;
}
// Печать массива array
void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.Write("]");
        Console.WriteLine("");
    }
}


