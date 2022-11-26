//Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
int rows = 4;
int columns = 4;
int rows1 = 4;
int columns1 = 4;
int[,] array = GetArray(rows, columns, 0, 5);
int[,] arr = GetArr(rows1, columns1, 0, 5);
PrintArray(array);
Console.WriteLine();
PrintArray(arr);
int[,] resultMatrix = new int[rows,columns1];
ProductArray(array, arr, resultMatrix);
Console.WriteLine("Произведение");
PrintArray(resultMatrix);

int[,] GetArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] result = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}
int[,] GetArr(int rows1, int columns1, int minValue, int maxValue)
{
    int[,] res = new int[rows1, columns1];
    for (int i = 0; i < rows1; i++)
    {
        for (int j = 0; j < columns1; j++)
        {
            res[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return res;
}

void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        Console.Write(" ");
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j], 3} ");
        }
        Console.WriteLine();
    }
}


void ProductArray(int[,] array, int[,] arr, int[,] resultMatrix)
{
  for (int i = 0; i < resultMatrix.GetLength(0); i++)
  {
    for (int j = 0; j < resultMatrix.GetLength(1); j++)
    {
      int sum = 0;
      for (int k = 0; k < array.GetLength(1); k++)
      {
        sum += array[i,k] * arr[k,j];
      }
      resultMatrix[i,j] = sum;
    }
  }
}