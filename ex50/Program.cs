// Напишите программу, которая на вход
// принимает позиции элемента в двумерном массиве, и
// возвращает значение этого элемента или же указание,
// что такого элемента нет.

Console.Clear();
Console.Write("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine() ?? "");
Console.Write("Введите количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine() ?? "");
Console.Write("Введите i: ");
int i = int.Parse(Console.ReadLine() ?? "");
Console.Write("Введите j: ");
int j = int.Parse(Console.ReadLine() ?? "");
if ((rows > i) && (columns > j))
{
    int[,] myArray = GetArray(rows, columns, 1, 10);
    int ijElement = ElementSearch(myArray, i, j);
    PrintArray(myArray);
    Console.WriteLine();
    Console.Write($"{i}; {j} -> {ijElement}");
}
else
{
    Console.WriteLine();
    Console.Write("Такого элемента нет");
}

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

void PrintArray(int[,] array)
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

int ElementSearch(int[,] array, int my_i, int my_j)
{
    int element = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if ((my_i == i) && (my_j == j))
            {
                element = array[i, j];
            }
        }
    }
    return element;
}