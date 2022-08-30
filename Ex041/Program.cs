// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 4

Console.Write("Введите числа: ");
string numbersString = Console.ReadLine();
string[] newNumbers = new string[numbersString.Length];

int a = 0;

for (int i = 0; i < numbersString.Length; i++)
{
    if (numbersString[i] == ' ')
    {
        a++;
    }
    else 
    {
        newNumbers[a] = newNumbers[a] + $"{numbersString[i]}";
    }
}
a++;
int[] resultNumbers = new int[a];
PrintArray (resultNumbers, newNumbers);

int count = 0;
for (int i = 0; i < a; i++)
{
    if (resultNumbers[i] > 0)
    {
        count++;
    }
}

Console.WriteLine("Количество чисел больше 0: " + count);

void PrintArray (int [] array, string [] string1)
{
  for (int i = 0; i < array.Length; i++)
  {
  array[i] = Convert.ToInt32(string1[i]);
  Console.Write (array[i] + "  ");
  }
Console.WriteLine();
}

