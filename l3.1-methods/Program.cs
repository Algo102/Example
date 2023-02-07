Console.Clear();
// МЕТОДЫ
// Вид 1 - метод который не принемает аргументы и ничего не возвращает
void Method1()
{
  Console.WriteLine("Авторство Algo"); // К примеру в конце программы указываем свое авторство
}
Method1(); // Вызов метода

// Вид 2 - метод который принемает аргументы и ничего не возвращает
void Method2(string msg)
{
  Console.WriteLine(msg);
}
Method2("Текст текст текст");
Method2(msg: "Текст текст текст");//можно указывать аргумент, если их несколько и нужно поменять местами

void Method21(string msg, int count)
{
  int i=0;
  while(i<count)
  {
    Console.WriteLine(msg);
    i++;
  }
}
Console.WriteLine(1);
Method21("Test",3);
Console.WriteLine(2);
Method21(msg: "Test", count: 3);
Console.WriteLine(3);
Method21(count: 3, msg: "Test");

// Вид 3 - ничего не принимает, но что-то возвращает
int Method3()
{
  return DateTime.Now.Year;
}
int xxx = Method3();
Console.WriteLine(xxx);

// Вид 4 - и принимает и возвращает
string Method4(int count, string text)
{
  int i = 0;
  string result = String.Empty;
  while (i < count)
  {
    result = result + text;
    i++;
  }
  return result;
}

string res = Method4(4, "Проба ");
Console.WriteLine(res);

// Вид 4 через for
string Method41(int count, string text)
{
  string result = String.Empty;
  for (int i = 0; i < count; i++)
  {
    result = result + text;
  }
  return result;
}

string res41 = Method41(4, "for ");
Console.WriteLine(res41);