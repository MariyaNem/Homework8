// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

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

int[,] array1 = CreateMatrixRndInt(3, 2, 1, 9);
PrintMatrix(array1);
Console.WriteLine();
int[,] array2 = CreateMatrixRndInt(2, 1, 1, 9);
PrintMatrix(array2);

if (array1.GetLength(1) != array2.GetLength(0))
{
    Console.WriteLine("Данные матрицы нельзя перемножить");
}
else
{
    Console.WriteLine($"Результирующая матрица:");
    int[,] twoMatrixProduct = TwoMatrixProduct(array1, array2);
    PrintMatrix(twoMatrixProduct);
}

int[,] TwoMatrixProduct(int[,] firstMatrix, int[,] secondMatrix)
{
    int[,] productMatrix = new int[firstMatrix.GetLength(0), secondMatrix.GetLength(1)];
    for (int i = 0; i < firstMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < secondMatrix.GetLength(1); j++)
        {
            for (int x = 0; x < secondMatrix.GetLength(0); x++)
            {
                productMatrix[i,j] += firstMatrix[i,x]*secondMatrix[x,j] ;
            }
           
        }
    }
    return productMatrix;
}