Console.WriteLine("Программа определяет какое число из двух больше");

Console.WriteLine("Введите первое число: ");
int number1 = int.Parse(Console.ReadLine() ?? "0"); 

Console.WriteLine("Введите второе число: ");
int number2 = int.Parse(Console.ReadLine() ?? "0"); 

if (number1>number2) // int max = number1 > number2 ? number1 : number2
{
  Console.WriteLine("Первое число " + number1 + " > " + "второго числа " + number2);
}
else 
{
  if (number2>number1)
  {
    Console.WriteLine("Второе число " + number2 + " > " + "первого числа " + number1);
  }
  else
  {
    Console.WriteLine("Ваши числа равные");
  }
}

