// Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке 
// и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int[,] GetRandomMatrix(int m, int n, int minValue, int maxValue)
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
            Console.Write($"{array[i, j]}\t ");
        }
        Console.WriteLine();
    }
}

int FindMinLineSumInMatrix(int[,] matrix)
{
    int minTotal = 0;
    int minLine = 0;
    for (int k = 0; k < matrix.GetLength(1); k++) minTotal += matrix[0, k];  // задаем первую сумму
    for (int i = 1; i < matrix.GetLength(0); i++)
    {
        int total = 0;
        for (int j = 0; j < matrix.GetLength(1); j++) total += matrix[i, j];  // плавающая сумма
        if (total < minTotal)
        {
            minTotal = total;
            minLine = i;
        }
    }
    return minLine;
}

Console.Clear();
int[,] matrix = GetRandomMatrix(m:3, n:3, minValue:1, maxValue:10);
PrintArray(matrix);
Console.WriteLine($"{FindMinLineSumInMatrix(matrix) + 1} строка");