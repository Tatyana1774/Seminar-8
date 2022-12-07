/*Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2 */

int colCount = ReadInt("Введите количество столбцов ");
int rowCount = ReadInt("Введите количество строк ");
int[,] arr = GenerateArray(rowCount, colCount);
Console.WriteLine("Исходный массив");
PrintArray(arr);
Console.WriteLine("Сортировка по строкам: ");
int[] row = new int[colCount];
for (int i = 0; i < rowCount; i++)
{
for (int j = 0; j < colCount; j++)
row[j] = arr[i, j];
BubbleSort(row);
Insert(true, i, row, arr);
}
PrintArray(arr);
//Метод генерации двумерного массива заданной размерности
void Insert(bool isRow, int dim, int[] source, int[,] dest)
{
for (int s = 0; s < source.Length; s++)
{
if (isRow)
dest[dim, s] = source[s];
else
dest[s, dim] = source[s];
}
}
int[,] GenerateArray(int t, int i)
{
int[,] table = new int[t, i];
Random random = new Random();
for (int a = 0; a < t; a++)
{
for (int b = 0; b < i; b++)
{
table[a, b] = random.Next(0, 9);
}
}
return table;
}
//Метод вывода двумерного массива в консоль
void PrintArray(int[,] array)
{
for (int a = 0; a < array.GetLength(0); a++)
{
for (int b = 0; b < array.GetLength(1); b++)
{
Console.Write(array[a, b] + " ");
}
Console.WriteLine();
}
}
//Метод сортировки массива по убыванию "Пузырьком"
void BubbleSort(int[] inArray)
{
int a;
for (int i = 0; i < inArray.Length; i++)

{
a = i;
for (int j = i; j < inArray.Length; j++)
{
if (inArray[j] > inArray[a])
{
a = j;
}
}
if (inArray[a] == inArray[i])
continue;
int temp = inArray[i];
inArray[i] = inArray[a];
inArray[a] = temp;
}
}

int ReadInt(string text)
{
Console.WriteLine(text);
return Convert.ToInt32(Console.ReadLine());
}