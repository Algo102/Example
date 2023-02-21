// Написать программу, которая в двумерном массиве заменяет строки на столбцы или сообщить, что это невозможно (в случае, если матрица не квадратная).
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
int m = IntNumder("Введите количество строк в массиве ");
int n = IntNumder("Введите количество столбцов в массиве ");

int[,] array = new int[m,n];
CreateRandArr(array, low, high);
PrintArr(array);
Console.WriteLine();

// Блок переворачивания столбцов и колонок c созданием нового массива
/*
if (m == n)
{
  int[,] arrayNew = new int[m,n];

  for( int i = 0; i<arrayNew.GetLength(0); i++)
    {
      for( int j = 0; j<arrayNew.GetLength(1); j++)
      {
        arrayNew[i,j] = array[j,i];
      }
      Console.WriteLine();
    }

  PrintArr(arrayNew);
}
else
  Console.WriteLine("Ваш массив не квадратный");
*/


// Блок переворачивания столбцов и колонок с помощью метода c созданием нового массива
/*
int[,] CrossArray(int[,] array)
{
  int[,] arrayNew = new int[array.GetLength(1),array.GetLength(0)];
  for( int i = 0; i<arrayNew.GetLength(0); i++)
  {
    for( int j = 0; j<arrayNew.GetLength(1); j++)
      arrayNew[i,j] = array[j,i];
  }
  return arrayNew;
}

if (m == n)
  PrintArr(CrossArray(array));
else
  Console.WriteLine("Ваш массив не квадратный");
  */

  //третий вариант с методом без создания нового массива
int[,] CrossArray(int[,] array)
{
  int temp = 0;
  for(int i = 0; i<array.GetLength(0); i++)
  {
    for(int j = i; j<array.GetLength(1); j++) //так как есть смысл пробегать только от главной диаганали, потому что все что ниже даганали уже частично поменяно
      {
        temp = array[i,j];
        array[i,j] = array[j,i];
        array[j,i] = temp;
      }
  }
  return array;
}

if (m == n)
  PrintArr(CrossArray(array));
else
  Console.WriteLine("Ваш массив не квадратный");