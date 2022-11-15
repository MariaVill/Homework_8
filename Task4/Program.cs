// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся
//  двузначных чисел. 
//  Напишите программу, которая будет построчно выводить массив, добавляя индексы 
//  каждого элемента.

// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

int[,,] CreateArray(int m, int n, int z)
{
    int[,,] massiv = new int[m, n, z];
    return massiv;
}

void FillArray(int[,,] massiv)
{
    for (int i = 0; i < massiv.GetLength(0); i++)
    {
        for (int j = 0; j < massiv.GetLength(1); j++)
        {
            for (int k = 0; k < massiv.GetLength(2); k++)
            {
                while (massiv[i, j, k] == 0)
                {
                    int number = new Random().Next(10, 40);
                    if (IsNumberInArray(massiv, number) == false)
                    {
                        massiv[i, j, k] = number;
                    }
                }

            }
        }
    }
}

bool IsNumberInArray(int[,,] massiv, int number)
{
    for (int i = 0; i < massiv.GetLength(0); i++)
    {
        for (int j = 0; j < massiv.GetLength(1); j++)
        {
            for (int k = 0; k < massiv.GetLength(2); k++)
            {
                if (massiv[i, j, k] == number) return true;
            }
        }
    }
    return false;
}

void PrintArray(int[,,] massiv)
{
    for (int i = 0; i < massiv.GetLength(0); i++)
    {
        for (int j = 0; j < massiv.GetLength(1); j++)
        {
            for (int k = 0; k < massiv.GetLength(2); k++)
            {
                Console.Write($"{massiv[i, j, k]}{(i, j, k)}" + "\t");
            }
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int m = 4;
int n = 2;
int z = 2;
int[,,] bigArray = CreateArray(m, n, z);
FillArray(bigArray);
PrintArray(bigArray);

