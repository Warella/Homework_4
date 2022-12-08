// Задача 40. Напишите программу, которая принимает на вход три числа и проверяет, являются ли они сторонами треугольника.
// Задача 42. Напишите программу, которая 

Console.Clear();
int DataInput(string str)
{
    Console.WriteLine(str);
    int number = int.Parse(Console.ReadLine());
    return number;
}

void Treugolnik(int a, int b, int c)
{
    if ( a + b < c || a + c < b || b + c < a)
    {
        Console.WriteLine("Это треугольник");
    }
}

int a = DataInput("Укажите длину стороны a: ");
int b = DataInput("Укажите длину стороны b: ");
int c = DataInput("Укажите длину стороны c: ");
Treugolnik(a, b, c);