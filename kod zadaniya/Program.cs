// Написать программу, которая из имеющегося массива 
// строк формирует новый массив из строк, 
// длина которых меньше, либо равна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями,
// лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []


string[] array = new string [5] {"-23", "Hello", "2", "world", ":-)"};

int GetCount(string[] array)
{
    int counter = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            counter++;
        }
    }
return counter;
}

string[] FillResult (int counter, string[] array)
{   
    string[] resultArray = new string[counter]; 
    int j = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            resultArray[j] = array[i];
            j++;
        }
    }
    return resultArray;
}

int counter = GetCount(array);
string [] resultArray = FillResult(counter, array);
Console.WriteLine(String.Join(" ", resultArray));
