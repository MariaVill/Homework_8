// Задача 54: Задайте двумерный массив. Напишите программу, 
// которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

int[,] CreateMassiv(int n, int m)
{
    int[,] array = new int[n, m];
    return array;
}

void FillArray(int[,] numbers)
{
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        for (int j = 0; j < numbers.GetLength(1); j++)
        {
            numbers[i, j] = new Random().Next(1, 20);
        }
    }
}

void PrintArray(int[,] numbers)
{
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        for (int j = 0; j < numbers.GetLength(1); j++)
        {
            Console.Write(numbers[i, j] + "\t");
        }
        Console.WriteLine();
    }

}

int[,] SortArray(int[,] numbers)
{
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        int temp = 0;
        for (int j = 0; j < numbers.GetLength(1); j++)
        {
            for (int k = 0; k < numbers.GetLength(1) - 1 - j; k++)
            {
                if (numbers[i,k] < numbers[i,k + 1])
                {
                    temp = numbers[i,k];
                    numbers[i,k] = numbers[i,k+1];
                    numbers[i,k+1] = temp;
                }
            }
        }
    }return numbers;
}

Console.Clear();
Console.Write("Введите размеры двумерного массива n и m: ");
int n = Convert.ToInt32(Console.ReadLine());
int m = Convert.ToInt32(Console.ReadLine());

int[,] MyMassiv = CreateMassiv(n, m);
FillArray(MyMassiv);
PrintArray(MyMassiv);
SortArray(MyMassiv);
Console.WriteLine("Отсортированный массив:");
PrintArray(MyMassiv);