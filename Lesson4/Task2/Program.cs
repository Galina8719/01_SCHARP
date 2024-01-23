﻿//Задача 22. Назовем число "интересным", если его сумма цифр четная.
//Создать двумерный массив, состоящий из целых чисел.
//Вывести на экран "интересные" элементы массива.

int[,] CreateMatrix(int rowount, int columsCount)
{
    int[,] matrix = new int[rowount, columsCount];

    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(1, 1000);
        }
    }
    return matrix;
}

void ShowMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}

int[,] matrix = CreateMatrix(5, 4);
ShowMatrix(matrix);

foreach (int e in matrix)
{
    if (IsInteresting(e) == true)
    {
        Console.WriteLine(e);
    }
}

bool IsInteresting(int value)
{
    int sumOFDigits = GetSumOFDigits(value);
    if (sumOFDigits % 2 == 0)
    {
        return true;
    }
        return false;
}

int GetSumOFDigits(int value)
{
    int sum = 0;
    while(value > 0)
    {
        sum = sum + value % 10;
        value = value / 10;
    }
    return sum;
}

