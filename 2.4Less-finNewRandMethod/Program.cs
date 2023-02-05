//программа для поиска элемента по значению
void FillArray(int[] collection) //метод для заполнения массива рандомом
{
  int lenght = collection.Length;
  int index = 0;
  while(index<lenght)
  {
    collection[index] = new Random().Next(1,10);
    index++;
  }
}

void PrintArray(int[] col) //метод для вывода массива на экран
{
  int count = col.Length;
  int position = 0;
  while (position<count)
  {
    Console.Write(col[position]+" ");
    position++;
  }
}

int IndexOf(int[]collection, int find) //метод для поиска элемента
{
  int count = collection.Length;
  int index = 0;
  int position = -1; //изначальная позиция, а взяли -1 на случай если тако элемента нет

  while(index<count)
  {
    if (collection[index] == find)
    {
      position = index;
      break;
    }
    index++;
  }
  return position;
}

int [] array = new int[10];

FillArray(array);
PrintArray(array);

Console.WriteLine();

int pos = IndexOf(array, 3);
Console.WriteLine(pos);