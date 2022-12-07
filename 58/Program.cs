/*Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18*/
int n1 = ReadInt("Введите количество строк в первой матрице: ");
int n2 = ReadInt("Введите количество столбцов в первой матрице: ");
int[,] arr = new int[n1, n2];
int n3 = ReadInt("Введите количество строк во второй матрице: ");
int n4 = ReadInt("Введите количество столбцов во второй матрице матрице: ");
int[,] arr1 = new int[n3, n4];
FillMatrixRandomNumbers(arr);
WriteMatrix(arr);
FillMatrixRandomNumbers1(arr1);
WriteMatrix1(arr1);
Console.WriteLine();

int[,] c = new int[arr.GetLength(0), arr1.GetLength(1)];
Matrix(c);
WriteMatrix1(c);

void Matrix(int[,] c)
{
if (arr.GetLength(1) != arr1.GetLength(0))
{
Console.WriteLine("Матрицы нельзя перемножить");
}
else
{
for (int i = 0; i < arr.GetLength(0); i++)
{
for (int j = 0; j < arr1.GetLength(1); j++)
{
for (int k = 0; k < arr1.GetLength(0); k++)
{
c[i, j] += arr[i, k] * arr1[k, j];
}

}
}
}
}

int ReadInt(string text)
{
Console.WriteLine(text);
return Convert.ToInt32(Console.ReadLine());
}
//Метод вывода двумерного массива в консоль

void WriteMatrix(int[,] arr)
{
for (int i = 0; i < arr.GetLength(0); i++)
{
for (int j = 0; j < arr.GetLength(1); j++)
{
Console.Write(arr[i, j] + " ");
}
Console.WriteLine();
}
Console.WriteLine();
}

void WriteMatrix1(int[,] arr1)
{
for (int i = 0; i < arr1.GetLength(0); i++)
{
for (int j = 0; j < arr1.GetLength(1); j++)
{
Console.Write(arr1[i, j] + " ");
}
Console.WriteLine();
}
Console.WriteLine();
}

void FillMatrixRandomNumbers(int[,] arr)
{
for (int i = 0; i < arr.GetLength(0); i++)
{
for (int j = 0; j < arr.GetLength(1); j++)
{
arr[i, j] = new Random().Next(1, 10);
}
}
}

void FillMatrixRandomNumbers1(int[,] arr1)
{
for (int i = 0; i < arr1.GetLength(0); i++)
{
for (int j = 0; j < arr1.GetLength(1); j++)
{
arr1[i, j] = new Random().Next(1, 10);
}
}
}