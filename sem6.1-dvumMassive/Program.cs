// Показать двумерный массив размером m×n заполненный целыми числами

void CreateArrayRND(int[,] arr, int low, int hi)
{
  Random random = new Random();
  for (int i = 0; i<arr.GetLength(0); i++)
    for (int j = 0; j<arr.GetLength(1); j++)
      arr[i,j] = random.Next(low, hi);
}

void PrintArray(int[,] arr)
{
  for (int i = 0; i<arr.GetLength(0); i++)
  {
    for (int j = 0; j<arr.GetLength(1); j++)
    {
      Console.Write($"{arr[i,j]} ");
    }
    Console.WriteLine();
  }
}

int IntRead(string message)
{
  Console.WriteLine(message);
  return int.Parse(Console.ReadLine()!);
}

int m = IntRead("Введите количество строк в массиве");
int n = IntRead("Введите количество столбцов в массиве");
int find = IntRead("Введите искомое число");

int[,] array = new int[m,n];
CreateArrayRND(array,1,10);
PrintArray(array);

Console.WriteLine();

//В двумерном массиве n×k заменить четные элементы на противоположные
for (int i = 0; i<array.GetLength(0); i++)
    for (int j = 0; j<array.GetLength(1); j++)
      if (array[i,j] % 2 == 0) array[i,j] =array[i,j]* (-1);
      
PrintArray(array);

//В двумерном массиве показать позиции числа, заданного пользователем или указать, что такого элемента нет
//bool flag = false;
int count = 0;
for (int i = 0; i<array.GetLength(0); i++)
    for (int j = 0; j<array.GetLength(1); j++)
      if (array[i,j] == find) 
      {
        //flag = true;
        count++;
        Console.WriteLine($"Ваше число находится в ячейке {i+1}-{j+1}");
      }
      
//if (flag == false) Console.WriteLine($"Ваше число {find} отсутствует в массиве"); 
if (count == 0) Console.WriteLine($"Ваше число {find} отсутствует в массиве");    

//ДРУГОЕ РЕШЕНИЕ С ПОИСКОМ ЧИСЛА
// void FindNumber(int[,] array, int find )
// {
//   bool flag = false;
//   for (int i = 0; i<array.GetLength(0); i++)
//   {
//     for (int j = 0; j<array.GetLength(1); j++)
//     {
//       if (array[i,j] == find) 
//       {
//         flag = true;
//         Console.WriteLine($"Ваше число находится в ячейке {i+1}-{j+1}");
//       }
//     }
//   }      
//   //if (flag == false) Console.WriteLine($"Ваше число {find} отсутствует в массиве"); 
//   if (!flag) Console.WriteLine($"Ваше число {find} отсутствует в массиве");
// }

// FindNumber(array, find);




// //ДРУГОЕ РЕШЕНИЕ С ПОИСКОМ ЧИСЛА
// string FindNum(int[,] table, int find)
// {
//   for (int i = 0; i<table.GetLength(0); i++)
//   {
//     for (int j = 0; j<table.GetLength(1); j++)
//     {
//     if (table[i,j] == find) return $"Ваше число находится в ячейке {i+1}-{j+1}";
//     }
//   }
//   return $"Ваше число {find} отсутствует в массиве";
// }

// Console.WriteLine(FindNum(array, find));