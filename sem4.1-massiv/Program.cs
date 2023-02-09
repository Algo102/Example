Console.Clear();
// // Массив со случайными числами
// int []array = new int[8];

// //Ввод массива
// for (int i = 0; i < array.Length; i++)
// {
//   array[i] = new Random().Next(1,10);
//   //Console.Write(" " + array[i]);
// }

// //Правильно делать ввод и вывод массива разными циклами, для
// //удобства чтения и возможной промежуточной обработки массива
// for (int i = 0; i < array.Length; i++)
// {
//   Console.Write(" " + array[i]);
// }




// //Задать массив из 12 элементов, заполненных числами из [0,9]. 
// //Найти сумму положительных/отрицательных элементов массива
// int []array = new int[12];

// for (int i = 0; i < array.Length; i++)
// {
//   array[i] = new Random().Next(-9,10);
// }
// int summPlus = 0;
// int summMinus = 0;

// for (int i = 0; i < array.Length; i++)
// {
//   if (array[i] > 0)
//   {
//     summPlus = summPlus + array[i];
//   }
//   else
//   {
//     summMinus = summMinus + array[i];
//   }
//   Console.Write(" " + array[i]);
// }
// Console.WriteLine($"\nСумма положительных элементов {summPlus}, отрицательных {summMinus}");




// //Задать массив из 12 элементов, заполненных числами из [-9,9]. 
// //Поменять знак у элемента
// int []array = new int[12];

// for (int i = 0; i < array.Length; i++)
// {
//   array[i] = new Random().Next(-9,10);
//   Console.Write("|\t" + array[i]);
// }

// Console.WriteLine("");

// for (int i = 0; i < array.Length; i++)
// {
//   array[i] = array[i] * (-1);
// }

// for (int i = 0; i < array.Length; i++)
// {
//   Console.Write("|\t" + array[i]);
// }




// //Определить, присутствует ли в заданном массиве, некоторое число
// Console.WriteLine("Введите число, которое ещем в этом массиве");
// int find = int.Parse(Console.ReadLine() ?? "0");
// int []array = new int[8];

// for (int i = 0; i < array.Length; i++)
// {
//   array[i] = new Random().Next(1,10);
// }

// for (int i = 0; i < array.Length; i++)
// {
//   Console.Write(array[i] + "|\t");
// }

// string result = "Такого числа нет (((";
// for (int i = 0; i < array.Length; i++)
// {
//   if(array[i] == find) 
//   {
//     result = "Я это сделал!!!!";
//     Console.WriteLine($"\n Число {find} есть, елемент {i+1}");
//   }
// }
// Console.WriteLine("\n" + result);




//Другое решение через строку и while, а так же механика в случае нет
int []a = {1,2,3,4,5,6,7};
var str = string.Join(" ", a); //перевод массива в строку
Console.WriteLine(str);

Console.WriteLine("Введите число, которое ещем в этом массиве");
int find = int.Parse(Console.ReadLine() ?? "0");

int i = 0;
int countFind = 0;

while (i < a.Length)
{
  if (a[i] == find)
  {
    Console.WriteLine($"\n Число {find} есть, елемент {i+1}");
    i++;
    countFind++; //если будет равен 0, чтоб выдало отрицательный результат
  }
  else
  {
    i++; //по правильному можно было вынести за else. В ifе удалить, и удалить else
  }
}

if (countFind == 0)
  Console.WriteLine("Такого числа в массиве нет");