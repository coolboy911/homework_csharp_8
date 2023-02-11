// Задайте две матрицы. Напишите программу, которая 
// будет находить произведение двух матриц.

// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}\t ");
        }
        Console.WriteLine();
    }
}

bool IsMatricesMultiplayable(int[,] matrixA, int[,] matrixB)
{
    return matrixA.GetLength(1) == matrixB.GetLength(0);
}

int[,] MultiplyMatrices(int[,] matrixA, int[,] matrixB)
{
    // пусть даны 2 прямоугольные матрицы A и B размерностью l * m и m * n соответственно:
    // тогда матрица C размерностью l * n
    int[,] resultMatrix = new int[matrixA.GetLength(0), matrixB.GetLength(1)];
    for (int l = 0; l < resultMatrix.GetLength(0); l++)  // передвигаемся по ячейкам созданной матрицы
    {
        for (int n = 0; n < resultMatrix.GetLength(1); n++)
        {
            for (int m = 0; m < matrixA.GetLength(1); m++)  // считаем значение ячейки
            {
                resultMatrix[l, n] += matrixA[l, m] * matrixB[m, n];
            }
        }
    }
    return resultMatrix;
}

int[,] matrixA = new int[,]
{
    {2, 4},
    {3, 2},
};

int[,] matrixB = new int[,]
{
    {3, 4},
    {3, 3},
};
Console.Clear();
PrintArray(matrixA);
Console.WriteLine("Помножить на");
PrintArray(matrixB);
Console.WriteLine("Равно");

if (IsMatricesMultiplayable(matrixA, matrixB))
{
    int[,] resultMatrix = MultiplyMatrices(matrixA, matrixB);
    PrintArray(resultMatrix);
}
else System.Console.WriteLine("Матрицы нельзя перемножить");