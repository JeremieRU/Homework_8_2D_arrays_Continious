int TakeConsoleInt(string str = "")
{
    int _num;
    Console.Write(str);
    int.TryParse(Console.ReadLine()!, out _num);
    return _num;
}

void PrintArray2d(Array arr, string str = "")
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr.GetValue(i, j)}{str} ");
        }
        Console.WriteLine();
    }
}

void PrintArray2dfor62(Array arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{String.Format("{0:00}", arr.GetValue(i, j))} ");
        }
        Console.WriteLine();
    }
}

int[,] FillArray2dInt(int length0 = 3, int length1 = 4, int min = 0, int max = 9)
{
    int[,] arr = new int[length0, length1];
    for (int i = 0; i < length0; i++)
    {
        for (int j = 0; j < length1; j++)
        {
            arr[i, j] = new Random().Next(min, (max + 1));
        }
    }
    return arr;
}

int[,] SortForLine(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            int minposition = j;
            for (int k = j + 1; k < arr.GetLength(1); k++)
            {
                if (arr[i, k] > arr[i, minposition])
                {
                    minposition = k;
                }
            }
            int temp = arr[i, j];
            arr[i, j] = arr[i, minposition];
            arr[i, minposition] = temp;
        }
    }
    return arr;
}

void SmallestLine(int[,] arr)
{
    int[] max = new int[arr.GetLength(0)];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        int maximum = 0;
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            maximum += arr[i, j];
        }
        max[i] = maximum;
    }
    int maxindex = 0;
    for (int k = 1; k < max.Length; k++)
    {
        if (max[0] < max[k])
        {
            maxindex = k;
        }
    }
    Console.Write($"Строка с наибольшей суммой элементов: {maxindex + 1}");
}

int[,] MatrixMultiplication2x2(int[,] arr1, int[,] arr2)
{
    int[,] matrixresult = new int[2, 2];
    matrixresult[0, 0] = arr1[0, 0] * arr2[0, 0] + arr1[0, 1] * arr2[1, 0];
    matrixresult[0, 1] = arr1[0, 0] * arr2[0, 1] + arr1[0, 1] * arr2[1, 1];
    matrixresult[1, 0] = arr1[1, 0] * arr2[0, 0] + arr1[1, 1] * arr2[1, 0];
    matrixresult[1, 1] = arr1[1, 0] * arr2[0, 1] + arr1[1, 1] * arr2[1, 1];
    return matrixresult;
}

int[,,] FillArray3dInt(int length0 = 2, int length1 = 2, int length2 = 2, int min = 10, int max = 99)
{
    int[,,] arr = new int[length0, length1, length2];
    for (int i = 0; i < length0; i++)
    {
        for (int j = 0; j < length1; j++)
        {
            for (int k = 0; k < length2; k++)
            {
                arr[i, j, k] = new Random().Next(min, (max + 1));
            }
        }
    }
    return arr;
}

void PrintArray3d(Array arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int k = 0; k < arr.GetLength(2); k++)
            {
                Console.Write($"{arr.GetValue(i, j, k)}({i},{j},{k}) ");
            }
            Console.WriteLine();
        }
    }
}

int[,] FillArray2dSpin(int[,] arr)
{
    for (int ik = 0; ik < arr.GetLength(0); ik++)
    {
        for (int jk = 0; jk < arr.GetLength(1); jk++)
        {
            int i = ik + 1;
            int j = jk + 1;
            int switcher = (j - i + arr.GetLength(0)) / arr.GetLength(0);
            int ic = Math.Abs(i - arr.GetLength(0) / 2 - 1) + (i - 1) / (arr.GetLength(0) / 2) * ((arr.GetLength(0) - 1) % 2);
            int jc = Math.Abs(j - arr.GetLength(0) / 2 - 1) + (j - 1) / (arr.GetLength(0) / 2) * ((arr.GetLength(0) - 1) % 2);
            int ring = arr.GetLength(0) / 2 - (Math.Abs(ic - jc) + ic + jc) / 2;
            int xs = i - ring + j - ring - 1;
            int coef = 4 * ring * (arr.GetLength(0) - ring);
            arr[ik, jk] = coef + switcher * xs + Math.Abs(switcher - 1) * (4 * (arr.GetLength(0) - 2 * ring) - 2 - xs);
        }
    }
    return arr;
}

switch (TakeConsoleInt("Введите номер задачи(54, 56, 58, 60, 62): "))
{
    default:
        Console.Write("Введён некорректный номер задачи");
        break;
    case 54:
        Console.Write("Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию\nэлементы каждой строки двумерного массива.\nНапример, задан массив:\n1 4 7 2\n5 9 2 3\n8 4 2 4\nВ итоге получается вот такой массив:\n7 4 2 1\n9 5 3 2\n8 4 4 2\n");
        Console.WriteLine();
        int[,] arr54 = FillArray2dInt(TakeConsoleInt("Введите количество строк: "),
            TakeConsoleInt("Введите количество столбцов: "),
            TakeConsoleInt("Введите минимальное значение массива: "),
            TakeConsoleInt("Введите максимальное значениемассива: "));
        Console.WriteLine();
        PrintArray2d(arr54);
        Console.WriteLine();
        PrintArray2d(SortForLine(arr54));
        break;
    case 56:
        Console.Write("Задайте прямоугольный двумерный массив. Напишите программу, которая будет\nнаходить строку с наименьшей суммой элементов.\nНапример, задан массив:\n1 4 7 2\n5 9 2 3\n8 4 2 4\n5 2 6 7\nПрограмма считает сумму элементов в каждой строке и выдаёт номер строки\nс наименьшей суммой элементов: 1 строка\n");
        Console.WriteLine();
        int length056 = TakeConsoleInt("Введите количество строк: ");
        int[,] arr56 = FillArray2dInt(length056, 2 * length056,
            TakeConsoleInt("Введите минимальное значение массива: "),
            TakeConsoleInt("Введите максимальное значениемассива: "));
        Console.WriteLine();
        PrintArray2d(arr56);
        Console.WriteLine();
        SmallestLine(arr56);
        break;
    case 58:
        Console.Write("Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.\nНапример, даны 2 матрицы:\n2 4 | 3 4\n3 2 | 3 3\nРезультирующая матрица будет:\n18 20\n15 18\n");
        int[,] arr58m1 = new int[2, 2];
        int[,] arr58m2 = new int[2, 2];
        int a58 = TakeConsoleInt("Введите минимальное значение массива для исходных матриц: ");
        int b58 = TakeConsoleInt("Введите максимальное значениемассива для исходных матриц: ");
        arr58m1 = FillArray2dInt(2, 2, a58, b58);
        arr58m2 = FillArray2dInt(2, 2, a58, b58);
        Console.WriteLine("matrix1:");
        PrintArray2d(arr58m1);
        Console.WriteLine("matrix2:");
        PrintArray2d(arr58m2);
        Console.WriteLine("result matrix: ");
        PrintArray2d(MatrixMultiplication2x2(arr58m1, arr58m2));
        break;
    case 60:
        Console.Write("Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу,\nкоторая будет построчно выводить массив, добавляя индексы каждого элемента.\nМассив размером 2 x 2 x 2\n66(0,0,0) 25(0,1,0)\n34(1,0,0) 41(1,1,0)\n27(0,0,1) 90(0,1,1)\n26(1,0,1) 55(1,1,1)\n");
        int[,,] arr60 = FillArray3dInt();
        Console.WriteLine("\nВаш новый трехмерный массив: \n");
        PrintArray3d(arr60);
        break;
    case 62:
        Console.Write("Напишите программу, которая заполнит спирально массив 4 на 4. \nНапример, на выходе получается вот такой массив:\n01 02 03 04\n12 13 14 05\n11 16 15 06\n10 09 08 07\n");
        Console.WriteLine();
        int size62 = TakeConsoleInt("Введите размер стороны массива: ");
        int[,] arr62 = new int[size62, size62];
        Console.WriteLine();
        PrintArray2dfor62(FillArray2dSpin(arr62));
        Console.WriteLine();
        break;
}