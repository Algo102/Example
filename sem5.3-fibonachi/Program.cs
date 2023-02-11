void PrintArray(int[] array)
{
  for (int i = 0; i < array.Length; i++)
    Console.Write($"{array[i]} ");
  Console.WriteLine();
}

int ReadInt(string message)
{
  Console.WriteLine(message);
  return int.Parse(Console.ReadLine()!);
}

int number = ReadInt("Введите до какого числа искать цифры Фибоначи");

int temp1 = 0;
int temp2 = 0;

int[] array = new int[20];
for (int i = 0; i < array.Length; i++)
{
  if (i>1)
  {
    temp1 = array[i-1];
    temp2 = array[i-2]; 
    if (temp1+temp2 > number) goto l1;
    else array[i] = temp1+temp2;
  }
  if (array[i] == 0) array[i] = 1;
}

l1:
PrintArray(array);



//другая версия
// int ReadInt(string message)
// {
//   Console.WriteLine(message);
//   return int.Parse(Console.ReadLine()!);
// }

// int number = ReadInt("Введите до какого числа искать цифры Фибоначи");
// int first = 1;
// int second = 1;
// int saver = 0;

// if (number > 0)
// {
//   Console.Write(first + " ");
//   Console.Write(second + " ");
// }

// while(first + second < number)
// {
//   saver = second;
//   Console.Write((first + second) + " ");
//   second += first;
//   first = saver;
// }