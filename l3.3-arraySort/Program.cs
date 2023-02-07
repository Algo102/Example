// Сортировка массива от минимума

int[] arr = {6, 1, 4, 8, 9, 7, 2, 3, 1};

void PrintArray(int[]array)
{
  int count = array.Length;

  for(int i = 0; i < count; i++)
  {
    Console.Write($"{array[i]} ");
  }
  Console.WriteLine();
}

void SelectionSortMin(int [] array)
{
  for(int i = 0; i < array.Length -1; i++)
  {
    int minPosition = i;

    for(int j = i+1; j < array.Length; j++) 
    {
      if(array[j] < array[minPosition]) minPosition =j;
    }
    int temporary = array[i];
    array[i] = array[minPosition];
    array [minPosition] = temporary;
  }
}

PrintArray(arr);

SelectionSortMin(arr);
PrintArray(arr);


// Сортировка массива от максимума

int[] arr2 = {6, 1, 4, 8, 9, 7, 2, 3, 1};

void PrintArray2(int[]array)
{
  int count = array.Length;

  for(int i = 0; i < count; i++)
  {
    Console.Write($"{array[i]} ");
  }
  Console.WriteLine();
}

void SelectionSortMax(int [] array)
{
  for(int i = 0; i < array.Length -1; i++)
  {
    int maxPosition = i;

    for(int j = i+1; j < array.Length; j++) 
    {
      if(array[j] > array[maxPosition]) maxPosition =j;
    }
    int temporary = array[i];
    array[i] = array[maxPosition];
    array [maxPosition] = temporary;
  }
}

PrintArray2(arr2);

SelectionSortMax(arr2);
PrintArray2(arr2);