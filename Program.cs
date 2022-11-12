//Метод запроса данных
string ReadData(string line)
{

    Console.Write(line);
    string a = Console.ReadLine();
    CheckString(a);
    return a;
}
//Обработка исключения на пустой массив
void CheckString(string x)
{

    if (string.IsNullOrWhiteSpace(x))
    {
        Console.ForegroundColor = ConsoleColor.Red;
        PrintData("Ошибка ввода: ", "значение Null ");
        Console.ResetColor();
        Environment.Exit(0);
    }

}
//Метод для получения результирующего массива
string[] ResultArray(string s)
{
    char[] separators = { ' ' };
    int a = 0;
    int k = 0;
    string[] split = s.Split(separators, StringSplitOptions.RemoveEmptyEntries);
    string[] array1 = new string[split.Length];
    for (int i = 0; i <= split.Length - 1; i++)

    {
        if (split[i].Length <= 3)
        {
            array1[k] = split[i];
            k++;
        }
    }
    if (k == 0)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("В исходном массиве нет элементов с длинной меньше либо равной 3 ");
        Console.ResetColor();
        Environment.Exit(0);
    }

    return array1;
}
// Метод вывода данных
void PrintData(string prefix, string value)
{
    Console.WriteLine(prefix + value);
}
Console.Clear();

string array = ReadData("Введите массив строк через пробел : ");
string[] newarray = ResultArray(array);
Console.ForegroundColor = ConsoleColor.Green;
PrintData("Результирующий массив: ", String.Join(" ", newarray));
Console.ResetColor();
