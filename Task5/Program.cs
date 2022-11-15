// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:

// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07


int n = 4;
int m = 4;
int[,] Massiv = CreateMassiv(n, m);
FillMassiv(Massiv, m, n);
PrintMassiv(Massiv);



int[,] CreateMassiv(int n, int m)
{
    int[,] numbers = new int[n, m];
    return numbers;
}

int[,] FillMassiv(int[,] massiv, int n, int m)
{
    int i = 0, j = 0;
    int firstElement = 1;

    while (firstElement <= massiv.GetLength(0) * massiv.GetLength(1))
    {
        massiv[i, j] = firstElement;
        firstElement++;
        if (i <= j + 1 && i + j < massiv.GetLength(1) - 1)
            j++;
        else if (i < j && i + j >= massiv.GetLength(0) - 1)
            i++;
        else if (i >= j && i + j > massiv.GetLength(1) - 1)
            j--;
        else
            i--;

    }
    return massiv;

}


void PrintMassiv(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] < 10) Console.Write($"{"0" + matrix[i, j], 3}");
            else Console.Write($"{matrix[i, j],3}");
        }
        Console.WriteLine();
    }

}

