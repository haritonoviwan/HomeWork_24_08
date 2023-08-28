// Задача 52: Задайте двумерный массив из целых чисел.
// Найдите среднее арифметическое элементов в каждом
// столбце.

Console.Clear();
Console.Write("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine() ?? "");
Console.Write("Введите количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine() ?? "");

int[,] myArray = GetArray(rows, columns, 1, 10);
PrintTwoDimensionalArray(myArray);
float[] averageArray = ColumnAverage(myArray);
Console.Write(String.Join("; ", averageArray));

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}

void PrintTwoDimensionalArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

float[] ColumnAverage(int[,] array)
{
    float[] result = new float[array.GetLength(1)];
    for (int j = 0; j < array.GetLength(1); j++)
    {
        float sum = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            sum = sum + array[i, j];
        }
        result[j] = sum / array.GetLength(0);
    }
    return result;
}
