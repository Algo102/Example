int Count(string str, char symbol)
{
  int count = 0;
  foreach(char element in str)
    if(element == symbol)
      count++;
  return count;
}


string[] Split(string str, char symbol)
{
  int length = Count(str, symbol);
  string[] strings = new string[length+1];
  int index = 0;
  for (int i=0; i < str.Length; i++)
  {
    string substring = "";
    while(i < str.Length && str[i] != symbol)
    {
      substring += str[i];
      i++;
    }
    strings[index] = substring;
    index++;
  }
  return strings;
}

string Substring(string str, int first, int last)
{
  string result = "";
  for(int i=first; i<last; i++)
    result += str[i];
  return result;
}

int[] ParseCoordinate(string stringCoordinate)
{
  int[] coordinate = new int[Count(stringCoordinate, ',')+1];
  string substring = Substring(stringCoordinate,1,stringCoordinate.Length-1);
  string[] stringValues = Split(substring, ',');

  for(int i= 0; i<coordinate.Length; i++)
    coordinate[i] = int.Parse(stringValues[i]);
  return coordinate;
}

int[,] ParseCoordinates(string str)
{
  int[,] coordinates = new int [Count(str, ' ')+1, 2];
  string[] stringCoordinates = Split(str, ' ');
  for(int i = 0; i < stringCoordinates.Length; i++)
  {
    int[] coordinateArray = ParseCoordinate(stringCoordinates[i]);
    for(int j =0; j<coordinateArray.Length; j++)
      coordinates[i,j]= coordinateArray[j];
  }
  return coordinates;
}


Console.Write("Введите координаты фигуры: ");
string figureCoordinates = Console.ReadLine()!;
Console.Write("Введите коэфициент умножения для координат ");
int koefficient = int.Parse(Console.ReadLine()!);

Console.WriteLine($"Координаты фигуры {figureCoordinates}");

int[,] coordinates = ParseCoordinates(figureCoordinates);
Console.Write("Scaled figure ");
for(int i=0; i<coordinates.GetLength(0); i++)
  Console.Write($"({coordinates[i,0]*koefficient}, {coordinates[i,1] * koefficient}) ");