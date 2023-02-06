Console.WriteLine("Программа определяет в пятизначном числе полиндром");

Console.WriteLine("Введите пятизначное число");
int number = Convert.ToInt32(Console.ReadLine());

int a = number/10000;
int b = (number-a*10000)/1000;
int c = ((number-a*10000)-2*1000)/100;
int d = (((number-a*10000)-2*1000)-c*100)/10;
int e = number%10;

// Console.WriteLine(a);
// Console.WriteLine(b);
// Console.WriteLine(c);
// Console.WriteLine(d);
// Console.WriteLine(e);

if (a==e & b==d) Console.WriteLine("Ваше число полиндром");
else Console.WriteLine("Ваше число НЕ полиндром");



// одно из решений, но по факту переводить цифры в строки не есть правильно и еще медленее
// Console.WriteLine("Введите пятизначное число");
// string? number = Console.ReadLine();

// char a = number[number.Length-1];
// char b = number[number.Length-2];
// char c = number[number.Length-4];
// char d = number[number.Length-5];

// Console.WriteLine(a);
// Console.WriteLine(b);
// Console.WriteLine(c);
// Console.WriteLine(d);

// if (a==d & b==c) Console.WriteLine("Ваше число полиндром");
// else Console.WriteLine("Ваше число НЕ полиндром");
