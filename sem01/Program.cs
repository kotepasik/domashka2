// // Напишите программу, 
// // которая выводит случайное число из отрезка [10, 99] 
// // и показывает наибольшую цифру числа.

// // 1. Уточнения
// // 2. Блок-схема
// //Console.WriteLine("number: " + number);
// //Console.WriteLine("number: {number}");
// //Console.Clear();


// int number = new Random().Next(10, 100); // [10, 100)
// Console.WriteLine($"number: {number}");
// int x = number / 10;
// int y = number % 10;

// if (x > y)
// {
//   Console.WriteLine(x);
// }
// else
// {
//   Console.WriteLine(y);
// }


// Задать массив из 8 элементов и вывести их на экран
// Уточнение
// буквы алфавита
// Прописные или строчные
// Случайные символы

// Метод создания массива
// Метод печати массива
// Метод заполнения массива
// Метод получения случайного символа

// Метод создания массива

char[] CreateArray(int count)
{
  return new char[count];
}
// Метод печати массива
void Print(char[] array)
{
  int len = array.Length;
  int i = 0;
  while (i < len)
  {
    Console.Write($"{array[i]} ");
    i++;
  }
  Console.WriteLine();
}
char GetChar()
{
  return Convert.ToChar(new Random().Next(64, 64 + 22));
}
char GetChar2()
{
  int sc = Convert.ToInt32('а');
  int ec = Convert.ToInt32('я');
  return Convert.ToChar(new Random().Next(sc, ec + 1));
}
char GetChar3()
{
  int sc = Convert.ToInt32('0');
  int ec = Convert.ToInt32('9');
  return Convert.ToChar(new Random().Next(sc, ec + 1));
}

// Метод заполнения массива
void Fill(char[] array)
{
  int length = array.Length;
  int i = 0;
  while (i < length)
  {
    array[i++] = GetChar3();
  }
}

char[] arg = CreateArray(8);
Fill(arg);
Print(arg);

// int length = 8;
// char[] arg = new char[length];
// int i = 0;
// while (i < length)
// {
//   int sc = Convert.ToInt32('а');
//   int ec = Convert.ToInt32('я');
//   arg[i] = Convert.ToChar(new Random().Next(sc, ec + 1));
//   Console.WriteLine(arg[i]);
//   i++;
// }

// string s = Console.ReadLine()!;

// int i = 0;
// int sum = 0;
// while (i < s.Length)
// {
//   sum = sum + Convert.ToInt32(s[i].ToString());
//   i++;
// }
// Console.WriteLine($"sum {sum}");