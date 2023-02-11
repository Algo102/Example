// Программа переводит десятичный код в двоичный
int ReadInt(string message)
{
  Console.WriteLine (message);
  return int.Parse(Console.ReadLine() !);
}

void PrintArray(int[] array)
{
  for (int i = 0; i < array.Length; i++)
    Console.Write($"{array[i]} ");

  Console.WriteLine();
}

int dec = ReadInt("Введите трехзначное дясятичное число");

int dec2 = dec;
int lenghtBin = 0;
while (dec2 > 0)
{
  dec2 /= 2;
  lenghtBin++;
}

Console.WriteLine("Разрядность введенного числа " + lenghtBin);

int[] array = new int [lenghtBin];

//Чтоб заполнять массив с конца можно поэксперементировать с
//for (int i=array.Length; i>0; i--)
for (int i=0; i<array.Length; i++)
  {
    array[array.Length-1-i] = dec % 2;
    // if (dec % 2 == 0)
    // {
    //   array[array.Length-1-i] = 0;
    // }
    // else 
    // {
    //   array[array.Length-1-i] = 1;
    // }
    dec=dec/2; //dec/=2
  }

PrintArray(array);