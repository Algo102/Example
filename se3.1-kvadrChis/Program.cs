// // программа ищет квадраты чисел
// Console.WriteLine("Введите количество чисел, по которым вы хотите увидеть их квадраты");
// int n = Convert.ToInt32(Console.ReadLine());

// int [] array = new int [n+1];

// for (int i = 1; i<array.Length; i++)
// {
//   array [i]=array [i]+i;
//   //Console.WriteLine(array [i] + " " + array [i]*array [i]);
//   Console.WriteLine("\t" + i + "\t" + i*i);
// }

// //Другое решение
// int count = 1;
// int res = 0;
// Console.WriteLine($"{"Пример", 15} {"Результат", 10}");

// while (count <= n)
// {
//   res = count * count;
//   Console.WriteLine($"{count, 10} * {count} = {res, 9}");
//   count++;
// }

// // Программа для поиска суммы от 1 до А
// Console.WriteLine("Введите количество чисел, по которым вы хотите знать сумму");
// int m = Convert.ToInt32(Console.ReadLine());

// int [] arr = new int [m+1];
// int summ = 0;

// for (int i = 1; i<arr.Length; i++)
// {
//   arr [i]=arr [i]+1;
//   summ=summ+i;
//   Console.WriteLine("\t" + i + "\t" + summ);
// }
// Console.WriteLine(summ);

// //другое решение
// int summm = 0;
// int con=1;
// while(con<=m)
// {
//   Console.WriteLine($"{con}) Summ {summm} + {con} = {summm+con}");
//   summm=summm+con;
//   con++;
// }
// Console.WriteLine("Итого "+summm);

// //вводим число, и его нужно ввести в сепень с помощью цикла
// Console.WriteLine("Введите число");
// int a = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите степень");
// int b = Convert.ToInt32(Console.ReadLine());

// double rez = 1;

// if (b == 0) Console.WriteLine("\t" + (0) + "\t" + 1);
// else
// {
//   for (int i =0 ; i<b; i++)
//   {
//     rez=rez*a; 
//     Console.WriteLine("\t" + (i+1) + "\t" + rez); 
//   }
// }
// Console.WriteLine(rez);


//определяем количество цифр в числе
// Console.WriteLine("Введите число");
// int c = Convert.ToInt32(Console.ReadLine());

// int schet = 1;

// while (c>9)
// {
//   c = c / 10;
//   schet++;
// }
// Console.WriteLine (schet);

// //Другое решение

// Console.WriteLine("Введите число");
// int d = Convert.ToInt32(Console.ReadLine());
// int schet1=0;
// if (d==0)
// {
//   schet1++;
//   Console.WriteLine(schet1);
// }
// else
// {
//   while (d != 0)
//   {
//     schet1++;
//     d = d / 10;
//   }
//   Console.WriteLine(schet1);
// }

//Поиск третьей цифры с конца
Console.WriteLine("Введите число");
int e = int.Parse(Console.ReadLine() ?? "0");
int threeEnd = e/100%10;
Console.WriteLine(threeEnd);
//Поиск третьей цифры с начала
while (e>=1000)
{
  e = e / 10;
}
Console.WriteLine(e%10);
