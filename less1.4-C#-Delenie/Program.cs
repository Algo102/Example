Console.WriteLine("Программа для вычисления частного двух чисел");
Console.WriteLine("Введите первое число: ");
double x = double.Parse(Console.ReadLine () ?? "0");
Console.WriteLine("Введите второе число: ");
double y = double.Parse(Console.ReadLine () ?? "0");
double rezult;
rezult = x / y;
Console.Write("Результат деления двух чисел: ");
Console.WriteLine(rezult);