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




void ArrayInit(string [] args)
{
    int index = 0;
    string input = System.Console.ReadLine();
    foreach (string word in input.Split(new char[] { ' ' }))
    {
       // System.Console.WriteLine("{0}: {1}", word, word.Length);
        System.Console.WriteLine($"{word}: {word.Length}");
        index++;
    }
    System.Console.WriteLine(index);
}


System.Console.WriteLine("Введите значения (буквы, числа, слова) через пробел и нажмите Enter");
ArrayInit(args);
//string[] array = new string[index - 1];
