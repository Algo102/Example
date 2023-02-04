Console.WriteLine("Программа высчитывает квадрат числа");
Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine() ?? "0"); //Convert.ToInt32
int result = number * number;
Console.WriteLine("Квадрат числа " + number + " равен " + result);