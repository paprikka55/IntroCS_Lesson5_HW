// Задача 4*(не обязательная): Задайте двумерный массив
// из целых чисел. Напишите программу, которая удалит
// строку и столбец, на пересечении которых расположен
// наименьший элемент массива. Под удалением
// понимается создание нового двумерного массива без
// строки и столбца

int[,] CreateRandomArray(int[] RowCol)
{
  int[,] arr = new int[RowCol[0], RowCol[1]];
  Random rnd = new Random();
  for(int i = 0; i < arr.GetLength(0); i++)
  {
    for(int j = 0; j < arr.GetLength(1); j++)
    {
      arr[i, j] = rnd.Next(0, 100);
    }
  }
  return arr;
}

int[] InputNumOfColsandRows()
{
  int[] RowCol = new int[2];
  while(true)
  {
    Console.Write("Для создания массива, введите количество строк: ");
    string rowStr = Console.ReadLine();
    if (int.TryParse(rowStr, out int rows))
    {
      RowCol[0] = rows;
      break;
    }
    Console.WriteLine();
  }
  while(true)
  {
    Console.Write("Для создания массива, введите количество столбцов: ");
    string colStr = Console.ReadLine();
    if (int.TryParse(colStr, out int cols))
    {
      RowCol[1] = cols;
      break;
    }
    Console.WriteLine();
  }
  return RowCol;
}

void PrintArray(int[,] array)
{
  for(int i = 0; i < array.GetLength(0); i++)
  {
    for(int j = 0; j < array.GetLength(1); j++)
    {Console.Write($"{array[i, j]}\t");}
    Console.WriteLine();
  }
  Console.WriteLine();
}

int[] FindIndOfMinEl(int[,] arr)
{
  int[] indexes = new int[2];
  int MinEl = arr[0, 0];
  for (int i = 0; i < arr.GetLength(0); i++)
  {
    for (int j = 0; j < arr.GetLength(1); j++)
    {
      if (MinEl > arr[i, j])
      {
        MinEl = arr[i, j];
        indexes[0] = i;
        indexes[1] = j;
      }
    }
  }
  return indexes;
}

int[,] CutArrayByMinElement(int[,] arr)
{
  int[,] cut_arr = new int[arr.GetLength(0) - 1, arr.GetLength(1) - 1];
  int[] MinElIndexes = FindIndOfMinEl(arr);
  int curRow = 0;
  int curCol = 0;
  bool NextRow = false;
  for (int i = 0; i < arr.GetLength(0); i++)
  { 
    curCol = 0;
    for (int j = 0; j < arr.GetLength(1); j++)
    {
      if (i != MinElIndexes[0] && j != MinElIndexes[1])
      {
        cut_arr[curRow, curCol] = arr[i, j];
        curCol++;
        NextRow = true;
      }
      else
      { NextRow = false; }
    }
    if (NextRow == true)
    { curRow++; }
    
  }
  return cut_arr;
}

int[,] array = CreateRandomArray(InputNumOfColsandRows());
Console.WriteLine("Рандомный массив: ");
PrintArray(array);
int[,] cut_arr = CutArrayByMinElement(array);
Console.WriteLine("Измененный массив: ");
PrintArray(cut_arr);
Console.ReadKey();
