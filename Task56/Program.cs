// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write(arr[i] + ", ");
        else Console.Write(arr[i]);
    }
    Console.WriteLine("]");
}

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],5},");
            else Console.Write($"{matrix[i, j],5}  ");
        }
        Console.WriteLine("]");
    }
}

int[] EachRowSum(int[,] matrix)
{
    int[] sumArr = new int[matrix.GetLength(0)];
    int rows = 0;
    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        for (int y = 0; y < matrix.GetLength(1); y++)
        {
            sumArr[i] += matrix[rows, y];
        }
        rows++;
    }
    return sumArr;
}

int MinElementInRow(int[] sumArr)
{
    int min = 0;
    for (int i = 1; i < sumArr.Length; i++)
    {
        if (sumArr[min] >= sumArr[i]) min = i;
    }
    return min;
}

int[,] array2D = CreateMatrixRndInt(4, 4, 1, 9);
PrintMatrix(array2D);
Console.WriteLine();
int[] eachRowSum = EachRowSum(array2D);
PrintArray(eachRowSum);
Console.WriteLine();
int minElementInRow = MinElementInRow(eachRowSum);
Console.Write($"Номер строки с наименьшей суммой элементов: {minElementInRow+1} строка");