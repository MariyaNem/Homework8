// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18


// int[,] CreateFirstMatrixRndInt(int rows, int columns, int min, int max)
// {
//     int[,] firstMatrix = new int[rows, columns];
//     Random rnd = new Random();

//     for (int i = 0; i < firstMatrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < firstMatrix.GetLength(1); j++)
//         {
//             firstMatrix[i, j] = rnd.Next(min, max + 1);
//         }
//     }
//     return firstMatrix;
// }

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

int[,] TwoMatrixProduct(int[,] firstMatrix, int[,] secondMatrix)
{
    int[,] productMatrix = new int[firstMatrix.GetLength(0), firstMatrix.GetLength(1)];
    for (int i = 0; i < firstMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < firstMatrix.GetLength(1); j++)
        {
           productMatrix[i,j] = firstMatrix[i,j]*secondMatrix[i,j];
        }
    }
    return productMatrix;
}

int[,] array1 = CreateMatrixRndInt(2, 3, 1, 9);
PrintMatrix(array1);
Console.WriteLine();
int[,] array2 = CreateMatrixRndInt(2, 3, 1, 9);
PrintMatrix(array2);
Console.WriteLine($"Результирующая матрица:");
int[,] twoMatrixProduct = TwoMatrixProduct(array1, array2);
PrintMatrix(twoMatrixProduct);