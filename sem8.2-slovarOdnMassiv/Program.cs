//Программа показывает сколько раз встречаются цифры в одномерном массиве
void FillArray(int[] array, int leftSide, int rightSide)
{
  Random random = new Random();
  for (int i = 0; i < array.Length; i++)
  {
    array[i] = random.Next(leftSide, rightSide);
  }
} 

void PrintArray(int[]array)
{
  foreach (int element in array)
  {
    Console.Write($"{element} ");
  }
  Console.WriteLine();
}

int ReadInt(string message)
{
  Console.Write(message);
  return int.Parse(Console.ReadLine()!);
}

// Метод подсчитывает количество вхождений элементов в массиве. Сколько раз встречается указанное число в массиве
int Count(int[] array, int value)
{
  int count = 0;
  foreach (int element in array)
    if (element == value)
      count++;
  return count;
}

// Метод который определяет, элемент уникальный или нет до указанного индекса.
bool ContainsBefor(int[] array, int index, int value)
{
  for (int i = 0; i < index; i++)
  if (array[i] == value)
    return true;
  return false;
}
// Метод считает количество уникальных элементов в массиве
int CountUniques(int[] array)
{
  int uniques = 0;
  for (int i = 0; i < array.Length; i++)
    if(!ContainsBefor(array, i, array[i]))
      uniques++;
  return uniques;
}

// Метод записывает уникальные элементы в новый массив
int[] Distinct(int[] array)
{
  int[] result = new int[CountUniques(array)];
  int index = 0;
  for (int i =0; i < array.Length; i++)
    if(!ContainsBefor(array, i, array[i]))
    {
      result[index] = array[i];
      index++;
    }
  return result;
}

int length = ReadInt("Введите длину массива "); 
int leftSide = ReadInt("Введите нижний диапозон элементов ");
int rightSide = ReadInt("Введите верхний диапозон элементов ");

int[] array = new int[length];
FillArray(array, leftSide, rightSide);
Console.Write("Ваш массив ");
PrintArray(array);

int[] uniques = Distinct(array);
foreach (int element in uniques)
  Console.WriteLine($"Элемент {element} встречается {Count(array, element)} раз");


Console.WriteLine();
