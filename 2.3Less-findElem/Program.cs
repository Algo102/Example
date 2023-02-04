Console.WriteLine("Программа ищет нужное число в массиве и указывает его элемент");
int []array = {15, 24, 28, 34, 43, 25, 36, 57, 28};

int n = array.Length;
int find = 43;
int index = 0;

while (index <n)
{
  if (array[index] == find)
  {
    Console.WriteLine("Ваш элемент " + index);
    break; //благодаря брейку, не ищет после нахождения первого совпадения
  }
    
  index++;
}