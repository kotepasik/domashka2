// Напишите программу, которая принимает на вход 
// координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0
// и выдаёт номер четверти плоскости, 
// в которой находится эта точка.
// координаты - double

// Напишите программу, которая по заданному номеру четверти,
// показывает диапазон возможных координат точек в этой четверти (x и y).

double TryGetDoubleFromConsole(string text)
{
  double temp = 0;
  bool flag = false;

  while (temp == 0 || !flag)
  {
    Console.Write(text);
    string str = Console.ReadLine()!;
    int pos = 0;
    flag = true;
    while (pos < str.Length)
    {
      if (!(str[pos] >= '1' && str[pos] <= '4'))
      {
        flag = false;
        break;
      }
      pos++;
    }
    if (str == String.Empty) flag = false;
    if (flag) temp = Convert.ToDouble(str);
  }

  return temp;
}
string GetResult(double n)
{
  string result = String.Empty;
  if (n==1)  result = "x > 0 && y > 0"; 
  if (n==2)  result = "x < 0 && y > 0"; 
  if (n==3)  result = "x < 0 && y < 0"; 
  if (n==4)  result = "x > 0 && y < 0"; 
 return result;
}

double n = TryGetDoubleFromConsole("Введите n: ");

//Console.WriteLine($"P({x};{y}) -> {GetResult(x, y)}");

Console.WriteLine($"{1}");




