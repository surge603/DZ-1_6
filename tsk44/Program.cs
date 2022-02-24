// Задача 44: Найти точку пересечения двух прямых заданных уравнением y = k1 * x + b1, y = k2 * x + b2, если b1, k1, b2 и k2 заданы

int EnterNum()
{
    return int.Parse(Console.ReadLine());
}

Console.Clear();
Console.WriteLine("Даны две прямые, заданные уравнениями y = k1 * x + b1 и y = k2 * x + b2,");
Console.WriteLine("Для нахождения координат точки пересечения прямых введите следующие параметры:");
Console.Write("Введите k1: ");
int k1 = EnterNum();
Console.Write("Введите k2: ");
int k2 = EnterNum();
if (k1 == k2)
{
    Console.WriteLine("Примые параллельны!");
    return;
}
Console.Write("Введите b1: ");
int b1 = EnterNum();
Console.Write("Введите b2: ");
int b2 = EnterNum();

double x = (b2 - b1) / (k1 - k2);
double y = k1 * x + b1;
Console.WriteLine($"Координаты точки пересечения: х={x}, y={y}");
