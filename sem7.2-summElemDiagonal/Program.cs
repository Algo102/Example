//В матрице чисел найти сумму элементов главной диагонали

void CreateRandArr(int[,] arr, int low, int high)
{
  Random rnd = new Random();
  for( int i = 0; i<arr.GetLength(0); i++)
    for( int j = 0; j<arr.GetLength(1); j++)
      arr[i,j] = rnd.Next(low,high+1);
}

void PrintArr(int[,] arr)
{
  for( int i = 0; i<arr.GetLength(0); i++)
  {
    for( int j = 0; j<arr.GetLength(1); j++)
    {
      Console.Write(arr[i,j]+ "  ");
    }
    Console.WriteLine();
  }
}

int IntNumder(string message)
{
  Console.WriteLine(message);
  return int.Parse(Console.ReadLine()!);
}

int low = IntNumder("Введите минимальное значение элемента ");
int high = IntNumder("Введите максимальное значение элемента ");
int m = IntNumder("Введите размер квадратного массива ");

// учитываем что в какой то момент, а именно в диагонали i и j одинаковые, то нет смысла крутить 2 цикла
// int sum = 0;
// for(int i = 0; i<array.GetLength(0); i++)
//   for(int j = 0; j<array.GetLength(1); j++)
//     if(i == j) sum =sum + array[i,j];

// Console.WriteLine(sum);


//другое решение через метод и с одним циклом
int SumDiaganal(int[,] array)
{
  int sum = 0;
  for(int i = 0; i<array.GetLength(0); i++)
    sum += array[i,i];
  return sum;
}

int[,] array = new int[m,m];
CreateRandArr(array, low, high);
PrintArr(array);
Console.WriteLine($"Сумма чисел главной диаганали: {SumDiaganal(array)}");