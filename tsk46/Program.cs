// Задача 46: Написать программу масштабирования фигуры

int EnterNum()
{
    return int.Parse(Console.ReadLine());
}

Console.Clear();
Console.WriteLine("Введите координаты вершин фигуры:");
int[] x = new int[4];
int[] y = new int[4];

for (int i = 0; i < 4; i++)
{
    Console.Write($"Введите х{i + 1}:");
    x[i] = EnterNum();
    Console.Write($"Введите y{i + 1}:");
    y[i] = EnterNum();
}
Console.Write("Введите коэффициент масштабирования фигуры:");

int k = EnterNum();

Console.WriteLine("Координаты отмасштабированной фигуры:");

for (int i = 0; i < 4; i++)
{
    Console.WriteLine($"x{i + 1} = {x[i] * k}");
    Console.WriteLine($"y{i + 1} = {y[i] * k}");
}
