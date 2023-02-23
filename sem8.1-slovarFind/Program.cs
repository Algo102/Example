using System.Linq;
using System.Collections.Generic;

// var a = new[] { 11, 11, 23, 23, 23, 23, 23, 44, 88, 88 };
// var g = a.GroupBy(i => i);
// Console.WriteLine("count: " + g.Count());
// foreach (var k in g)
//     Console.WriteLine(k.Key + " (" + k.Count() + ")");


//Другой вариант
/*
var a = new[] { 11, 11, 23, 23, 23, 23, 23, 44, 88, 88 };
var h = new Dictionary<int, int>();
foreach (var i in a)
{
    int res;
    if (h.TryGetValue(i, out res))
        h[i] += 1;
    else
        h.Add(i, 1);
}
Console.WriteLine("count: " + h.Count);
foreach(var kv in h)
    Console.WriteLine(kv.Key + " (" + kv.Value + ")");
*/

// Метод печати
void PrintArray(string[,] array, string text)
{
  Console.WriteLine("\n");
  Console.WriteLine(text);

  for(int i = 0; i < array.GetLength(0); i++)
  {
    for(int j = 0; j < array.GetLength(1); j++)
    {
      Console.Write($" {array[i,j]} \t");
    }
    Console.WriteLine();
  }
}

// Метод который создает одномерный - трехстроковый массив в который записывает, сам уникальный символ, сколько раз он астречается, и как часто он встречается.
string[] Frequency(string LookFor, string numbers)
{
  string[] frequency = new string[3];
  double freq = 0;
  int count = 0;

  for (int i = 0; i < numbers.Length; i ++)
  {
    if(LookFor == numbers[i].ToString()) count++;
  }

  double countDouble = double.Parse(count.ToString());
  double stringLength = double.Parse((numbers.Length).ToString());
  freq = Math.Round(countDouble/stringLength*100,2);

  frequency[0] = LookFor;
  frequency[1] = count.ToString();
  frequency[2] = freq.ToString();
  return frequency;
}


// Метод подсчета количествва индивидуальных символов
int CountElements(string numbers)
{
  int flag = 0;
  char LookFor;
  string individuals = string.Empty;
  int count = 1;
  individuals = numbers[0].ToString();
  
  for(int i = 1; i < numbers.Length; i++)
  {
    LookFor = numbers[i];
    for (int j = 0; j < individuals.Length; j++)
    {
      if (LookFor == individuals[j])
      {
        flag = 1;
      }
    } 

    if(flag == 0)
    {
      individuals = LookFor.ToString();
      count++;
    }
    flag = 0;
  }
  return count;
}

// Метод смотрит встречался ли элемент в первом столбце двумерного массива
bool KnowElementInFirstColumn(string LookFor, string[,] matrix)
{
  int flag = 0;
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    if (matrix[i,0] == LookFor) flag = 1;
  }
  if (flag == 1) return true;
  else return false;
}

// Главные метод который уже смотрит с какой частотой встречался символ
string [,] Frequencies(string numbers)
{
  int count = CountElements(numbers);
  string[] element = new string[3];
  string[,] newMatrix = new string[count,3];
  int i = 0;
  int j = 0;

  while (j < numbers.Length)
  {
    if(!KnowElementInFirstColumn(numbers[j].ToString(), newMatrix))
    {
      element = Frequency(numbers[j].ToString(), numbers);
      newMatrix[i,0] = element[0];
      newMatrix[i,1] = element[1];
      newMatrix[i,2] = element[2];
      i++;
    }
    j++;
  }
  return newMatrix;
}

string numbers = "привет ребята как дела";

string [,] summary = Frequencies(numbers);
PrintArray(summary, "Итог:");
