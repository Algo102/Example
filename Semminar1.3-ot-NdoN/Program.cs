//Console.Clear;
Console.WriteLine("Программа с шагом 1 идет до модуля этого числа");

Console.WriteLine("Введите отрицательное целое число: ");
int number1 = Convert.ToInt32(Console.ReadLine()); 

int step = number1*(-1)+1;


while (number1 != step)
{
  Console.Write(number1 + "  ");
  number1++;
}
