// СОБРАТЬ СТРОКУ С ЧИСЛАМИ от a до b
// string NumbersFor(int a, int b)
// {
//   string result = String.Empty;
//   for (int i = a; i <= b; i++)
//   {
//     result += $"{i} ";
//   }
//   return result;
// }

// string NumbersRec(int a, int b)
// {
//   if (a<=b) 
//     return $"{a} " + NumbersRec (a + 1, b);
//   else 
//     return String.Empty;
// }
// Console.WriteLine(NumbersFor(1, 10));
// Console.WriteLine(NumbersRec(1, 10));





// СОБРАТЬ СТРОКУ С ЧИСЛАМИ от b до a
// Просто поменяли местами в первом ретурне
// string NumbersBAfor(int a, int b)
// {
//   string result = String.Empty;
//   for (int i = a; i >= b; i--)
//   {
//     result += $"{i} ";
//   }
//   return result;
// }


// string NumbersBArec(int a, int b)
// {
//   if ( a <= b) 
//     return NumbersBArec(a + 1, b) + $"{a} ";
//   else 
//     return String.Empty;
// }
// Console.WriteLine(NumbersBAfor(10, 1));
// Console.WriteLine(NumbersBArec(1, 10));


//или так
// string NumbersAB(int a, int b)
// {
//   if (b >= a) 
//     return $"{b} " + NumbersAB (a, b -1);
//   else 
//     return String.Empty;
// }
// Console.WriteLine(NumbersAB(1, 10));



// СУММА ЧИСЕЛ ОТ 1 ДО N
// int SumNumberFor(int N)
// {
//   int result = 0;
//   for(int i = 1; i <= N; i++)
//     result += i;
//   return result;
// }
// Console.WriteLine(SumNumberFor(10));

// int SumNumberRec(int N)
// {
//   if (N == 0) 
//     return 0;
//   else
//     return N + SumNumberRec(N - 1);  
// }
// Console.WriteLine(SumNumberRec(10));



// ФАКТОРИАЛ ЧИСЛА
// int FactorialFor(int n)
// {
//   int result = 1;
//   for (int i = 1; i <= n; i++)
//     result *= i;
//   return result;
// }

// int FactorialRec(int n)
// {
//   if (n ==1) 
//     return 1;
//   else 
//     return n * FactorialRec(n-1);
// }
// Console.WriteLine(FactorialFor(10));
// Console.WriteLine(FactorialRec(10));



// ВЫЧИСЛЯЕМ a В СТЕПЕНИ n
int PowerFor(int a, int n)
{
  int result = 1;
  for (int i = 1; i <= n; i++)
    result *= a;
  return result;
}
Console.WriteLine(PowerFor(2, 10));

int PowerRec(int a, int n)
{
  if (n == 0) return 1;
  else 
    return PowerRec(a, n - 1) * a;
}
Console.WriteLine(PowerRec(2, 10));