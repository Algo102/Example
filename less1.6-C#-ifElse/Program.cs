Console.WriteLine("Привет, пожалуйста представьтесь");
string? username = Console.ReadLine();
if (username.ToLower() == "саша") //ToLower, понижает в нижний регистр
  Console.WriteLine("Добро пожаловать Сашуля"); //Фигурные скобки можно не ставить, если одна строка
else
{
  Console.WriteLine("Привет," + " " + username + " че надо?");
}