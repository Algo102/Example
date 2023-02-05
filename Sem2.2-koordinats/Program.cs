Console.WriteLine("Программа определяет в какой части координат лежит точка");

Console.WriteLine("Введите X");
int x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите Y");
int y = Convert.ToInt32(Console.ReadLine());

if (x>0 & y>0) Console.WriteLine("Ваша точка в I четверти");
else if (x<0 & y>0) Console.WriteLine("Ваша точка во II четверти");
else if (x<0 & y<0) Console.WriteLine("Ваша точка в III четверти");
else Console.WriteLine("Ваша точка в IV четверти");