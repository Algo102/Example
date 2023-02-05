Console.WriteLine("Программа проверяет делится ли введеное число на 7 и 23");

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());

int del7 = number % 7;
int del32 = number % 23;

if (del7 == 0 & del32 == 0)
{
  Console.WriteLine("Ваше число делится на 7 и 23");
}
else
{
  Console.WriteLine("Ваше число не делится на 7 и 23");
}
