//Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
//Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

int firstDimension = 2;
int secondDimension = 2;
int thirdDimension = 2;
int masSize = firstDimension * secondDimension * thirdDimension;
Random rnd = new Random();
int[] inArray = GetInArray(0, masSize);
Console.WriteLine(string.Join(' ', inArray));
inArray = inArray.OrderBy(x => rnd.Next()).ToArray();
Console.WriteLine(string.Join(' ', inArray));
int[,,] array = GetArray(firstDimension, secondDimension, thirdDimension, 0, 10);//new int[10, 20 , 30];
PrintArray(array);

int[] GetInArray(int minValue, int maxValue)
{
    int masSize = maxValue - minValue;
    int[] result = new int[masSize];
    for (int i = 0; i < masSize; i++)
    {
        result[i] = minValue++;

    }
    return result;
}

int[,,] GetArray(int firstDimension, int secondDimension, int thirdDimension, int minValue, int maxValue)
{
    int[,,] result = new int[firstDimension, secondDimension, thirdDimension];
    int count = 0;
    for (int i = 0; i < firstDimension; i++)
    {
        for (int j = 0; j < secondDimension; j++)
        {
            for (int k = 0; k < thirdDimension; k++)
            {
                result[i, j, k] = inArray[count];
                count++;
            }
        }
    }
    return result;
}

void PrintArray(int[,,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        Console.Write(" ");
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int k = 0; k < arr.GetLength(2); k++)
            {
                Console.Write($"{arr[i, j, k],3}({i}, {j}, {k}) ");
            }
        }
        Console.WriteLine();
    }
}