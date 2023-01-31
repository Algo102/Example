Console.WriteLine("Программа для вычисления суммы двух чисел");
Console.WriteLine("Оба числа выбираются случайным методом от 1 до 9");
double x = new Random().Next(1,10); // 1 2 3 4 ... 9
double y = new Random().Next(1,10);
double rezult;
rezult = x + y;
Console.Write("Первое число: ");
Console.WriteLine(x);
Console.Write("Второе число: ");
Console.WriteLine(y);
Console.Write("Результат суммирования двух чисел: ");
Console.WriteLine(rezult);