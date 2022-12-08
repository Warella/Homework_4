// Задача 45: Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.

Console.Clear();


int[] FillArrayWithRandomNumbers(int size, int leftRange, int rigthRange)
{
    Random rand = new Random();
    int[] arr = new int[size];
    for( int i =0; i < size; i++)
    {
        arr[i] = rand.Next(leftRange, rigthRange + 1);
    }
    return arr;
}

int[] CopyArray(int[] arr)
{
    int[] newArray = new int[arr.Length];
    for (int i = 0; i < arr.Length; i++)
    {
        newArray[i] = arr[i];
    }
    return newArray;
}

int[] firstArray = FillArrayWithRandomNumbers(5, 3, 5);
Console.WriteLine("[" + string.Join(",", firstArray) +"]");
int[] secondArray = CopyArray(firstArray);
Console.WriteLine("[" + string.Join(",", secondArray) +"]");