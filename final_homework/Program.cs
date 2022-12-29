/*
Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых 
меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на 
старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись 
исключительно массивами. 

["hello", "2", "world", ":-)"] -> ["2", ":-)"]
["1234", "1567", "-2", "computer science"] -> ["-2"]
["Russia", "Denmark", "Kazan"] -> []
*/

// Ввод элементов массива с консоли
string[] InitArray()
{
   string text = string.Empty;
   string[] array = new string[0];
   while (text != "Q")
   {
      Console.WriteLine("Введите элемент. Конец ввода 'Q'");
      text = Console.ReadLine()!;
      if (text != "Q")
      {
         array = array.Append(text).ToArray();
      }
   }
   return array;
}

// Получение массива элементов с не более 3 символов
string[] GetArray(string[] initArray)
{
   string[] newArray = new string[0];
   for (int i = 0; i < initArray.Length; i++)
   {
      if (initArray[i].Length <= 3)
      {
         newArray = newArray.Append(initArray[i]).ToArray();
      }
   }
   return newArray;
}

// Печать массива
void PrintArray(string[] array)
{
   for (int i = 0; i < array.Length; i++)
   {
      Console.Write($"'{array[i]}', ");
   }
   Console.WriteLine("");
}

string[] initArray = InitArray();
Console.WriteLine("\nВведеный массив:");
PrintArray(initArray);

string[] newArray = GetArray(initArray);
Console.WriteLine("\nМассив с элементами не более 3 символов:");
PrintArray(newArray);

