// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
// Напишите программу, которая будет построчно выводить массив, 
// добавляя индексы каждого элемента.

// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

int[,,] GetUniqueRandom3DArray(int m, int n, int o, int minValue, int maxValue)
{
    int[,,] array = new int[m, n, o];
    int[] usedNumbersArray = new int[0];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                // создаем уникальное число и дописываем его в список использованных
                int rand = new Random().Next(minValue, maxValue + 1);
                int l = 0;
                while (l < usedNumbersArray.Length)
                {
                    if (rand == usedNumbersArray[l])
                    {
                        rand = new Random().Next(minValue, maxValue + 1);
                        l = 0;
                    }
                    else l++;
                }
                array[i, j, k] = rand;
                Array.Resize(ref usedNumbersArray, usedNumbersArray.Length + 1);
                usedNumbersArray[usedNumbersArray.Length - 1] = rand;
            }
        }
    }
    return array;
}

void Print3DArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($"{array[i, j, k]}({i}, {j}, {k})\t ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}

Console.Clear();
int m = 3;
int n = 3;
int o = 3;
int minValue = 10;
int maxValue = 36;
if (m * n * o > maxValue - minValue + 1)
{
    Console.WriteLine("Невозможно создать массив с введенными параметрами");
    Console.WriteLine("из за нехватки уникальных целых чисел");
}
else
{
    int[,,] array3D = GetUniqueRandom3DArray(m, n, o, minValue, maxValue);
    Print3DArray(array3D);
}