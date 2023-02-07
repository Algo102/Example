Console.WriteLine("Таблица умножения");

for (int i = 2; i < 10; i++)
  {
    for (int j = 2; j < 10; j++)
    {
    Console.WriteLine($"{i} * {j} = {i*j}");
    }
    Console.WriteLine();
  }


//Работа с текстом
//Пробелы заменяем на дефисы
//к меняем на К, С меняем на с

string text = "- Я думаю, - сказал князь улыбаясь, - что"
            + "ежели  бы  вас  послали  вместо нашего милого Винценгероде, "
            + "вы бы взяли приступом согласие прусского короля. "
            + "Вы так красноречивы. Вы дадите мне чаю?";

// string s = "qwerty"
//             012345
// s[3]   //r

string Replace(string text, char oldV, char newV)
{
  string result = String.Empty; //инициализация пустой строки
  int lenght = text.Length;
  for (int i = 0; i < lenght; i++)
  {
    if (text[i] == oldV) result = result + $"{newV}";
    else  result = result + $"{text[i]}";

  }
  return result;
}

string newText = Replace(text, ' ', '|');
Console.WriteLine(newText);
newText = Replace(newText, 'к', 'К');
Console.WriteLine(newText);
newText = Replace(newText, 'С', 'с');
Console.WriteLine(newText);