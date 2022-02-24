// Задача 42: Определить, сколько чисел больше 0 введено с клавиатуры.

Console.Clear();
Console.WriteLine("Введите любое количество чисел. Ввод каждого числа завершайте клавишей Enter.");
Console.WriteLine("Для завершения программы и подсчёта количества введенных отрицательных чисел введите \"-\"");
int result = 0;
while (true)
{
    Console.Write("Введите число или \"-\" для завершения: ");
    string str = Console.ReadLine();
    if (str == "-" || str == "")
        break;
    int num = int.Parse(str);
    if (num < 0)
    {
        result++;
        Console.WriteLine($"Введено отрицательное число!");
    }
}
Console.WriteLine($"Введено отрицательных чисел: {result}");
