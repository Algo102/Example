Console.WriteLine();
//СЧИТАЕТ ФАКТОРИАЛ ЧИСЛА
// метод возвращает целое число и принимает аргумент из целого числа
//int Factorial(int n)
// double Factorial(int n) //так как на 17! идет переполнение типа даных, то меняем int  на double, у него разрядность  больше
// {
//   // 0! = 1
//   // 1! = 1
//   if (n == 1) return 1;
//   else return n*Factorial(n-1); //5*4*3*2*1
// }

// Console.WriteLine(Factorial(3)); //3*2*1=6

// for (int i = 1; i < 10; i++)
//   Console.WriteLine($"{i}! = {Factorial(i)}"); //вывод на экран последовательно



//ЦИФРЫ ФИБОНАЧИ
// 1 1 2 3 5 8 13
// f(1) = 1
// f(2) = 1
// f(n) = f(n-1) +f(n-2)

int Fibonacci(int n)
{
  if (n == 1 || n == 2) return 1;
  else return Fibonacci(n-1) + Fibonacci(n-2);
}

for (int i = 1; i < 40; i++)
{
  Console.WriteLine(i + " = " + Fibonacci(i));
}



