/*Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)*/
Console.WriteLine("Введите размер массива ");
int a = ReadInt("Введите размер a ");
int b = ReadInt("Введите размер b ");
int c = ReadInt("Введите размер c ");
int[,,] arr = new int[a, b, c];
CreateArr(arr);
WriteArr(arr);

void WriteArr(int[,,] arr)
{
for (int i = 0; i < arr.GetLength(0); i++)
{
for (int j = 0; j < arr.GetLength(1); j++)
{

for (int k = 0; k < arr.GetLength(2); k++)
{
Console.Write($"{arr[i,j,k]}({i}, {j}, {k}) ");
}
Console.WriteLine();
}
Console.WriteLine();
}
}

void CreateArr(int[,,] arr)
{
int[] temp = new int[arr.GetLength(0) * arr.GetLength(1) * arr.GetLength(2)];
int number;
for (int i = 0; i < temp.GetLength(0); i++)
{
temp[i] = new Random().Next(10, 50);
number = temp[i];
if (i >= 1)
{
for (int j = 0; j < i; j++)
{
while (temp[i] == temp[j])
{
temp[i] = new Random().Next(10, 50);
j = 0;
number = temp[i];
}
number = temp[i];
}
}
}
int count = 0;
for (int a = 0; a < arr.GetLength(0); a++)
{
for (int b = 0; b < arr.GetLength(1); b++)
{
for (int c = 0; c < arr.GetLength(2); c++)
{
arr[a, b, c] = temp[count];
count++;
}
}
}
}

int ReadInt(string text)
{
Console.WriteLine(text);
return Convert.ToInt32(Console.ReadLine());
}