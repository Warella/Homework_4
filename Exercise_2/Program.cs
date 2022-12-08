// Задача 42. Напишите программу, которая переводит в двоичный код

Console.Clear();
int DataInput(string str)
{
    Console.WriteLine(str);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

void GetBinaryView(int num)
{
    if (num <= 0)
    {
        return;
    }
    GetBinaryView(num/2);
    Console.Write(num%2);
}

int a = DataInput("Введите число: ");
GetBinaryView(a);
