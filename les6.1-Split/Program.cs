// Работа со сплитом и массивом строк

using System.Linq;

string text = "(1,2) (2,3) (4,5) (6,7)"
        .Replace("(", "") // убрали скобки
        .Replace(")", "");

Console.WriteLine(text);
Console.WriteLine();

//string[] data = text.Split(" ")
var data = text.Split(" ") //по пробелу перенесли строками в массив
        .ToArray();

for(int i = 0; i < data.Length; i++)
{
  Console.WriteLine(data[i]);
}