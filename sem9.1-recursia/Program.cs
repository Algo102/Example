// Найти сумму цифр числа
// void SumNumbers(int number, int sum)
// {
//     if (number>0)
//    {
//         sum += number%10; 
//         Console.WriteLine(sum);
//         if (number/10==0) Console.WriteLine(sum);
//         SumNumbers(number/10, sum);
//     }
// }

// Console.Write("Введите N: ");
// int number = int.Parse(Console.ReadLine()!);
// int sum = 0;
// Console.WriteLine();
// SumNumbers(number, sum);

// Другое решение с одной переменной
// int SumNumbers(int number)
// {
//     if (number < 1) return 0;
//     return SumNumbers(number/10) + number %10;
// }

// Console.Write("Введите N: ");
// int number = int.Parse(Console.ReadLine()!);
// Console.Write(SumNumbers(number));



//Показать натуральные числа от N до 1, N задано
// void NaturNambers(int number)
// {
//     if (number >= 1)
//     {
//         Console.WriteLine(number);
//         NaturNambers(number-1);
//     }
// }
// Console.Write("Введите N: ");
// int number = int.Parse(Console.ReadLine()!);
// NaturNambers(number);

//Другой вариант
// void NaturNambers(int number)
// {
//     Console.Write(number + " ");
//     if (number == 1)
//         Console.WriteLine("Done");
//     else
//         NaturNambers(number - 1);
    
// }
// Console.Write("Введите N: ");
// int number = int.Parse(Console.ReadLine()!);
// NaturNambers(number);

//Показать натуральные числа от 1 до N, N задано
// void NaturNambers(int number, int max)
// {
//     Console.WriteLine(number + " ");
//     if (number == max)
//         Console.WriteLine("Done");
//     else
//         NaturNambers(number + 1, max);
    
// }
// Console.Write("Введите N: ");
// int number = int.Parse(Console.ReadLine()!);
// NaturNambers(1, number);

//другое решение с одной переменной
//так как рекурсия выдает данные, только после того как сам пройдет все циклы, то поменяв строчки местами, он будет выдавать в обратном порядке. То есть прямой и обратный ход в рекурсии
void NaturNambers(int number)
{
    if (number != 0)
    {
        NaturNambers(number-1);
        Console.WriteLine(number);
    }
}
Console.Write("Введите N: ");
int number = int.Parse(Console.ReadLine()!);
NaturNambers(number);