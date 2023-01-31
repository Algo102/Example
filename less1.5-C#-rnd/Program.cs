Console.WriteLine("Программа для вычисления суммы двух чисел");
Console.WriteLine("Оба числа выбираются случайным методом от 1 до 9");
double x = new Random().Next(1,10); // 1 2 3 4 ... 9
double y = new Random().Next(1,10);
double rezult;
rezult = x + y;
Console.Write("Первое число: " + x);
Console.Write("\nВторое число: " + y); // \n перевод корретки на новую строку
Console.Write("\nРезультат суммирования двух чисел: " + rezult);