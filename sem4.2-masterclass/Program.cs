// метод по выводу массива на экран
void PrintArray(int[] array)
{
  for (int i = 0; i < array.Length; i++)
    Console.Write($"{array[i]} ");

  Console.WriteLine();
}

// метод по созданию массива
int[] GreatArray(int length, int left, int right)
{
  Random random = new Random();
  int[] array = new int [length];

  for (int i = 0; i < array.Length; i++)
    array[i] = random.Next(left,right+1);
  
  return array;
}

//Метод по поиску елемента в массиве
bool FindElement(int[]array, int find)
{
  //bool flag = false;
  for (int i = 0; i < array.Length /*&&flag == false*/; i++)
    if (array[i] == find)
      //flag = true;
      // // break; //оператор break нужно использовать при крайней необходимости, как и continue
      return true;
  //return flag;
  return false;
}

int ReadInt(string message)
{
  Console.WriteLine (message);
  return int.Parse(Console.ReadLine() !);
}


// Console.WriteLine ("Enter size massive");
// int length = int.Parse(Console.ReadLine() ?? "0");
int length = ReadInt("Enter size massive");

// Console.WriteLine ("Enter left part range in random");
// int left = int.Parse(Console.ReadLine() !); // чтоб не выдавало ошибку вместо ?? "0" можно поставит !
int left = ReadInt("Enter left part range in random");

// Console.WriteLine ("Enter right part range in random");
// int right = int.Parse(Console.ReadLine() !);
int right = ReadInt("Enter right part range in random");

// Console.WriteLine ("Enter find element");
// int find = int.Parse(Console.ReadLine() !);
int find = ReadInt("Enter find element");

// Random random = new Random();
// int[] array = new int [length];

// for (int i = 0; i < array.Length; i++)
//   array[i] = random.Next(left,right+1);
int[] array = GreatArray(length, left, right);

// for (int i = 0; i < array.Length; i++)
//   Console.Write($"{array[i]} ");

// Console.WriteLine();
PrintArray(array);

// bool flag = false;
// for (int i = 0; i < array.Length; i++)
//   if (array[i] == find)
//     flag = true;
bool flag = FindElement(array, find);

if (flag == true)
  Console.WriteLine("This is element intro massive");
else
  Console.WriteLine("This is massive don't have this element");

