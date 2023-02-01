Console.WriteLine("Программа ищет самую тяжелую гирю из 5");
int a = 9;
int b = 8;
int c = 3;
int d = 2;
int e = 4;
int maxim = a;
if (b > maxim)
  maxim = b;
if (c > maxim)
  maxim = c;
if (d>maxim)
  maxim = d;
if (e>maxim)
  maxim = e;
Console.WriteLine ("Самая тяжелая гиря имеет вес: " + maxim);