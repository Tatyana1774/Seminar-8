/* Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка */

int n1 = ReadInt("Введите количество строк в матрице: ");
int n2 = ReadInt("Введите количество столбцов в матрице: ");
int[,] arr = new int[n1, n2];
Random rnd = new Random();

// Присвоение значений датчиком случайных чисел
for (int i = 0; i < n1; i++)
for (int j = 0; j < n2; j++)
arr[i, j] = rnd.Next(-0, 10 + 1);

//Вывод массива
for (int i = 0; i < n1; i++, Console.WriteLine())
for (int j = 0; j < n2; j++)
Console.Write(arr[i, j]+ " ");
int minRowSum = int.MaxValue, indexMinRow = 0;

for (int i = 0; i < n1; i++)
{
int rowSum = 0;
for (int j = 0; j < n2; j++)
rowSum += arr[i, j];

if (rowSum < minRowSum)
{
minRowSum = rowSum;
indexMinRow = i;
}
}

Console.WriteLine($"Строка {indexMinRow +1} с минимальной суммой элементов"); //+1 для удобства восприятия пользователем
for (int j = 0; j < n2; j++)
Console.Write(arr[indexMinRow, j]+ " ");
Console.WriteLine();

int ReadInt(string text)
{
Console.WriteLine(text);
return Convert.ToInt32(Console.ReadLine());
}