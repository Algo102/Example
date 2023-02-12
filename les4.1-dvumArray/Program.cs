﻿// // ОБРАЗЕЦ СОЗДАНИЯ ДВУМЕРНОГО МАССИВА
//string[,] table = new string[2,5];
//2 строки и 5 столбцов
// table[1,2] = "слово";
// for(int rows = 0; rows < 2; rows++)
// {
//   for(int columns = 0; columns < 5; columns++)
//   {
//     Console.Write($"-{table[rows,columns]}- "); //поставил -, чтоб видеть заполнение ячеек, по умолчанию пусто
//   }
//   Console.WriteLine();
// }



// int[,] matrix = new int[3,4];
// for(int i = 0; i < matrix.GetLength(0); i++) //указываем GetLength(0) для строк в двумерных массивах
// {
//   for(int j = 0; j < matrix.GetLength(1); j++) //указываем GetLength(1) для столбцов в двумерных массивах
//   {
//     Console.Write($"{matrix[i,j]} "); 
//   }
//   Console.WriteLine();
// }


// МЕТОД ПО ВЫВОДУ НА ЭКРАН ПУСТОГО ДВУМЕРНОГО МАССИВА
void PrintArrayII(int[,] matr)
{
  for(int i = 0; i < matr.GetLength(0); i++) 
  {
    for(int j = 0; j < matr.GetLength(1); j++) 
    {
      Console.Write($"{matr[i,j]} "); 
    }
    Console.WriteLine();
  }
}

// МЕТОД ПО СОЗДАНИЮ ДВУМЕРНОГО МАССИВА ИЗ РАНДОМНЫХ ЧИСЕЛ
void CreateRandArrayII(int[,] matr, int low, int hi)
{
  Random random = new Random();
  for(int i = 0; i < matr.GetLength(0); i++) 
  {
    for(int j = 0; j < matr.GetLength(1); j++) 
    {
      matr[i,j] = random.Next(low,hi); 
    }
    Console.WriteLine();
  }
}


//МЕТОД ПО ОБРАБОТКИ МАССИВА ВВИДЕ КАРТИНКИ, КОТОРЫЙ ПЕРЕВОДИТ 0 В ПРОБЕЛ, А 1 В +
void PrintImage(int[,] image)
{
  for(int i = 0; i < image.GetLength(0); i++) 
  {
    for(int j = 0; j < image.GetLength(1); j++) 
    {
      //Console.Write($"{i[i,j]} "); 
      if (image[i,j] == 0) Console.Write($" ");
      else Console.Write($"+");
    }
    Console.WriteLine();
  }
}



int[,] matrix = new int[3,4];
PrintArrayII(matrix);

Console.WriteLine();

CreateRandArrayII(matrix, 1, 10);
PrintArrayII(matrix);

int[,] pic = new int[,]
{
{0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
{0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
{0,0,0,0,0,0,0,0,0,0,0,0,1,1,0,0,0,0,0,0,0,0,0,0,0},
{0,0,0,0,0,0,0,0,0,0,0,1,0,0,1,0,0,0,0,0,0,0,0,0,0},
{0,0,0,0,0,0,0,0,0,0,1,0,0,0,1,0,0,0,0,0,0,0,0,0,0},
{0,0,0,0,0,0,0,0,0,1,0,0,0,1,0,0,0,0,0,0,0,0,0,0,0},
{0,0,0,0,0,0,0,0,1,0,0,0,1,0,0,0,0,0,0,0,0,0,0,0,0},
{0,0,0,0,0,0,0,1,0,0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0},
{0,0,1,1,1,1,1,0,0,0,0,1,1,1,1,1,1,1,1,1,0,0,0,0,0},
{0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,0,0,0,0},
{0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,0,0,0,0},
{0,0,1,0,0,0,0,0,0,0,0,1,1,1,1,1,1,1,1,1,1,0,0,0,0},
{0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,0,0,0},
{0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,0,0,0},
{0,0,1,0,0,0,0,0,0,0,0,1,1,1,1,1,1,1,1,1,1,0,0,0,0},
{0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,0,0,0,0},
{0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,0,0,0,0},
{0,0,1,0,0,0,0,0,0,0,0,1,1,1,1,1,1,1,1,1,0,0,0,0,0},
{0,0,1,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,0,0,0,0,0},
{0,0,0,0,1,1,1,0,0,0,0,0,0,0,0,0,0,0,0,1,0,0,0,0,0},
{0,0,0,0,0,0,0,1,1,1,1,1,1,1,1,1,1,1,1,0,0,0,0,0,0},
{0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
{0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
};

//МЕТОД ПО ЗАКРАШИВАНИЮ ЗАМКНУТОГО КОНТУРА
//Метод вызывает сам себя - Рекурсия
void FillImage(int row, int col) //аргументы это позиция, откуда начнется закраска
{
  if (pic[row, col] == 0) //если текущей пиксель не закрашен
  {
    pic[row, col] = 1; //то будем закрашиваь 1
    FillImage (row-1, col); //вызывает сам себя с сдвигом на 1 наверх
    FillImage (row, col-1); //с тойже позиции но на 1 влево
    FillImage (row+1, col); //с тойже позиции но на 1 вниз
    FillImage (row, col+1); //с тойже позиции но на 1 вправо
  }
}

PrintImage(pic);
FillImage(13,13); //случайная точка внутри контура
PrintImage(pic);