Console.WriteLine("Программа для вычисления суммы двух целых чисел");
Console.WriteLine("Введите первое число: ");
int x = int.Parse(Console.ReadLine () ?? "0");
Console.WriteLine("Введите второе число: ");
int y = int.Parse(Console.ReadLine () ?? "0");
int sum;
sum = x + y;
Console.Write("Сумма двух чисел равна: ");
Console.WriteLine(sum);