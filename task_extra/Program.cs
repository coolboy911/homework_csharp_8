// Написать функцию Sqrt(x) - квадратного корня, которая принимает 
// на вход целочисленное значение x и возвращает целую часть 
// квадратного корня от введенного числа.
// 4 -> 2
// 28 -> 5
// Нельзя использовать встроенные функции библиотеки Math!

int Sqrt(int x)
{
    if (x == 0 || x == 1) return x;
    int upperBound = x / 2 + 1;
    int lowerBound = (upperBound + (x / upperBound)) / 2;
    int count = 0;
    while(lowerBound < upperBound)
    {
        upperBound = lowerBound;
        lowerBound = (upperBound + (x / upperBound)) / 2;
        Console.WriteLine($"{++count} повторение");
    }
    return upperBound;
}

Console.Clear();
Console.Write("введите число: ");
int x = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Ответ: {Sqrt(x)} (первый вариант)");