// Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j],-4}");
        }
        Console.WriteLine();
    }
}

int[,] GetSpiralSerialMatrix(int m, int n)
{
    int[,] matrix = new int[m, n];

    int upBorder = 0, downBorder = m - 1;
    int leftBorder = 0, rightBorder = n - 1;
    int row = 0, column = 0;

    int count = 1;
    matrix[0, 0] = count++;

    for (int i = 1; i < m * n; i++)
    {
        if (row == upBorder && column < rightBorder) //right
        {
            matrix[row, ++column] = count++;
            if (column == rightBorder && row == upBorder) upBorder++;
        }
        else if (column == rightBorder && row < downBorder) //down
        {
            matrix[++row, column] = count++;
            if (row == downBorder && column == rightBorder) rightBorder--;
        }
        else if (row == downBorder && column > leftBorder) //left
        {
            matrix[row, --column] = count++;
            if (column == leftBorder && row == downBorder) downBorder--;
        }
        else if (column == leftBorder && row > upBorder) //up
        {
            matrix[--row, column] = count++;
            if (row == upBorder && column == leftBorder) leftBorder++;
        }
    }
    return matrix;
}

Console.Clear();
int[,] spiralMatrix = GetSpiralSerialMatrix(4,4);
PrintArray(spiralMatrix);