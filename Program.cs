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

//выводит лишнюю запятую при втором примере

string[] ArrayInit(string[] args)
{
    string input = System.Console.ReadLine();
    string[] array = input.Split(new char[] { ' ' });
    return array;
}

void ArrayCountLetters(string[] array)
{
    System.Console.Write("Конечный массив: [");
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length < 4)
        {
            if (i != array.Length - 1)
            {
                System.Console.Write($"“{array[i]}”");
            }
            else
            {
                System.Console.Write($"“{array[i]}”");
            }
        }
        else continue;
    }
    System.Console.Write("]");
}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (i != array.Length - 1)
        {
            System.Console.Write($"“{array[i]}”, ");
        }
        else System.Console.WriteLine($"“{array[i]}”]");
    }
}




Console.Clear();
System.Console.Write("Введите значения (буквы, числа, слова) через пробел и нажмите Enter: ");
string[] array = ArrayInit(args);
System.Console.Write("Исходный массив: [");
PrintArray(array);
ArrayCountLetters(array);