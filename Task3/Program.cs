// Задача 58: Задайте две матрицы. Напишите программу,
//  которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18



int[,] CreateMatrix(int m, int n)
{
    int[,] array = new int[m, n];
    return array;
}

void FillAMatrix(int[,] numbers)
{
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        for (int j = 0; j < numbers.GetLength(1); j++)
        {
            numbers[i, j] = new Random().Next(1, 5);
        }
    }
}

void PrintMatrix(int[,] numbers)
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

void NewMatrix(int[,] Matrix1, int[,] Matrix2, int[,] newMatrix)
{
    for (int i = 0; i < newMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < newMatrix.GetLength(1); j++)
        {
            int result = 0;
            for (int k = 0; k < Matrix1.GetLength(1); k++)
            {
                result += Matrix1[i, k] * Matrix2[k, j];
                newMatrix[i, j] = result;
            }


        }
    }
}


Console.Clear();
Console.WriteLine(@"Введите колличество строк(m) и количество столбцов(n)
                   для первой матрицы A: ");
int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(@"Введите колличество строк(a) и количество столбцов(b)
                   для втрой матрицы B: ");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());

if (n == b)
{
    Console.WriteLine("Матрицы А и В можно перемножить и получить матрицу С");
    Console.WriteLine();

    int[,] Matrix1 = CreateMatrix(m, n);
    FillAMatrix(Matrix1);
    Console.WriteLine("Матрица А:");
    PrintMatrix(Matrix1);
    Console.WriteLine();

    int[,] Matrix2 = CreateMatrix(a, b);
    FillAMatrix(Matrix2);
    Console.WriteLine("Матрица B:");
    PrintMatrix(Matrix2);
    Console.WriteLine();

    Console.WriteLine("Матрица C = A*B:");

    int[,] Matrix3 = new int[m, b];
    NewMatrix(Matrix1, Matrix2, Matrix3);
    PrintMatrix(Matrix3);
}
else Console.WriteLine("Произведения этих матриц не существует");