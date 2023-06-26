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


void ArrayInit(int arraySize, string[] array)
{
    for (int i = 0; i < arraySize; i++)
    {
        array[i] = System.Console.ReadLine();
    }
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

string[] CountSymbols(string[] array, int cropNum)
{
    System.Console.Write("Конечный массив: [");
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= cropNum)
        {
            if (i != array.Length - 1)
            {
                System.Console.Write($"“{array[i]}”");
            }
            else
            {
                System.Console.Write($", “{array[i]}”");
            }
        }
        else continue;
    }
    System.Console.Write("]");
    return array;
}


Console.Clear();
System.Console.Write("Введите размер массива (сколько планируете вводить слов): ");
int arraySize = Convert.ToInt32(System.Console.ReadLine());

System.Console.WriteLine("Введите значения (буквы, числа, слова) через Enter: ");
string[] array = new string[arraySize];
ArrayInit(arraySize, array);
System.Console.Write("Исходный массив: [");
PrintArray(array);

System.Console.Write("Введите число символов по которому сравнивается длина слова: ");
int cropNum = Convert.ToInt32(System.Console.ReadLine());
CountSymbols(array, cropNum);