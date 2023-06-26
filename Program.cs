// Задача: Написать программу, которая из имеющегося массива строк
//формирует новый массив из строк, длина которых меньше,
//либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры,
//либо задать на старте выполнения алгоритма.
//При решении не рекомендуется пользоваться коллекциями,
//лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []




int ArraySize(string[] args) //определяем размер массива
{
    int index = 0;
    string? input = System.Console.ReadLine();
    foreach (string? word in input.Split(new char[] { ' ' })) index++;
    return index;
}

void ArrayPrint(string[] args, int arraySize)
{
    int index = 0;
    System.Console.Write("Повторите ввод: ");
    string? input = System.Console.ReadLine();
    System.Console.Write("Получился такой массив: [");
    foreach (string? word in input.Split(new char[] { ' ' }))
    {
        if (index != arraySize - 1)
        {
            System.Console.Write($"“{word}”, ");
            //System.Console.Write($"{word}: {word.Length}");
            index++;
        }
        else System.Console.Write($"“{word}”");
    }
    System.Console.WriteLine("]");
}
// void PrintArray(string[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//       //  if (i != array.Length)
//         //    System.Console.Write($"{array[i]}, ");
//        // else
//        System.Console.WriteLine(array[i]);
//     }
//     System.Console.WriteLine();
// }




Console.Clear();
System.Console.WriteLine("Введите значения (буквы, числа, слова) через пробел и нажмите Enter");
int arraySize = ArraySize(args);
ArrayPrint(args, arraySize);
//string[] array = new string[arraySize - 1];
//PrintArray(array);
