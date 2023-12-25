/*
    Задача: Написать программу, которая из имеющегося массива строк 
формирует новый массив из строк, длина которых меньше, либо равна 3 символам. 
Первоначальный массив можно ввести с клавиатуры, либо задать на старте 
выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
лучше обойтись исключительно массивами.

Примеры:
[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
[“Russia”, “Denmark”, “Kazan”] → []
*/

/*
    Вывод массива строк на консоль
*/
void ShowStringArray(string[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($" '{array[i]}'");
        if (i < array.Length-1)
            Console.Write(",");
    }
    Console.WriteLine(" ]");
}

/*
    Ввод массива строк с консоли (вариант со списком строк)
string[] InputStringArray()
{
    var tmp = new List<String>();   
    Console.WriteLine("Enter strings, or 'q' for end input.");
    while (true)
    {
        string s = Console.ReadLine() + ""; // добавляем "", чтобы ReadLine() не вернула NULL
        if (s == "q" || s == "Q")
            break;
        tmp.Add(s);
    }
    string[] res = tmp.ToArray();   // конвертируем список в массив
    return res;
}
*/

/*
    Ввод массива строк с консоли (вариант с изменением размера массива)
*/
string[] InputStringArray()
{
    string[] res = Array.Empty<string>();
    Console.WriteLine("Enter strings, or 'q' for end input.");
    while (true)
    {
        string s = Console.ReadLine() + ""; // добавляем "", чтобы ReadLine() не вернула NULL
        if (s == "q" || s == "Q")
            break;
        Array.Resize(ref res, res.Length+1);
        res[^1] = s;            // добавляем строку в последний элемент массива
    }
    return res;
}
    
/*
    Подсчитывает количество строк, заданной длины, в массиве
*/
int GetStringsCount(string[] array, int minLen, int maxLen)
{
    int count = 0;
    foreach (string s in array)
    {
        int len = s.Length;
        if (len >= minLen && len <= maxLen)
            count++;
    }
    return count;
}

/*
    Создаёт массив строк из заданного, отбирая из него только те строки,
    чья длина не выходит за диапазон [minLen..maxLen]
*/
string[] SelectStrings(string[] array, int minLen, int maxLen)
{
    int newLen = GetStringsCount(array, minLen, maxLen); // узнаём размер для целевого массива
    /*
        Если не подходит ни одного элемента, то возвращаем пустой массив.
        Можно вернуть NULL, но тогда придется вводить дополнительные проверки.
    */
    if (newLen == 0)
        return Array.Empty<string>();
    /*
        формируем целевой массив
    */    
    string[] result = new string[newLen]; 
    int newIdx = 0;

    for (int i = 0; i < array.Length; i++)
    {
        int len = array[i].Length;
        if (len >= minLen && len <= maxLen)
            result[newIdx++] = array[i];
    }
    return result;
}


Console.Clear();
string[] source = InputStringArray();       // вводим массив строк
ShowStringArray(source);
string[] res = SelectStrings(source, 0, 3); // отбираем из него строки длиной не более 3 символов
ShowStringArray(res);
