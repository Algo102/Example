// Даны 3 стороны, нужно узнать, эти стороны принадлежат одному треугольнику?

int ReadInt(string message)
{
  Console.WriteLine (message);
  return int.Parse(Console.ReadLine() !);
}

// bool Check(int a, int b, int c)
// {
//   if (a<(b+c) && b<(a+c) && c<(b+a)) return true;
//   return false; 
// }

//а правильнее так
// bool Check(int a, int b, int c)
// {
//   return (a<(b+c) && b<(a+c) && c<(b+a));
// }

//а так еще правильнее, так как одна строка
//bool Check(int a, int b, int c) => a<b+c & b<a+c & c<b+a;

//А так еще правильнее с точки зрения трудо затрат ПК, так как при & cверяются все условия, а при | (или) достаточно найти оно не подхлдящее условие. Соответственно меняем знаки с < на >, & меняем на |. И на в ConsoleWriteLine меняем местами
bool Check(int a, int b, int c) => a>b+c | b>a+c | c>b+a;




int a = ReadInt("Введите длину первой стороны");
int b = ReadInt("Введите длину второй стороны");
int c = ReadInt("Введите длину третьей стороны");

// Console.WriteLine(Check(a,b,c) ? "Три стороны являются сторонами треугольника" : "Эти стороны не могут принадлежать треугольнику");
Console.WriteLine(Check(a,b,c) ? "Эти стороны не могут принадлежать треугольнику" : "Три стороны являются сторонами треугольника");



//Похожие решение, но без метода
// Console.WriteLine("Enter distance of three sides");
// Console.Write("First side: ");
// int sideOne = int.Parse(Console.ReadLine()!);
// Console.Write("Second side: ");
// int sidetwo = int.Parse(Console.ReadLine()!);
// Console.Write("Third side: ");
// int sideThree = int.Parse(Console.ReadLine()!);

// if (sideOne + sidetwo < sideThree || sideOne + sideThree < sidetwo || sidetwo + sideThree < sideOne)
// Console.WriteLine("Not a triangle!");
// else
// Console.WriteLine("Triangle!");