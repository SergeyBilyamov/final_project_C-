string[] sourceArray = FillArray();
string[] resultArray = GenerateNewArray(sourceArray);
string firstArray = PrintArray(sourceArray);
string secondArray = PrintArray(resultArray);
Console.WriteLine(firstArray + " -> " + secondArray);

string[] FillArray()
{
    Console.WriteLine("Введите данные через пробел, по окончании ввода нажмите Enter: ");
    string? enterSymbols = Console.ReadLine();
    if (enterSymbols == null) { enterSymbols = ""; };
    char[] separators = new char[] { ',', ' ' };
    string[] sourceArray = enterSymbols.Split(separators, StringSplitOptions.RemoveEmptyEntries);
    return sourceArray;
}

string PrintArray(string[] sourceArray)
{
    string stringArray = "[";
    for (int i = 0; i < sourceArray.Length; i++)
    {
        if (i == sourceArray.Length - 1)
        {
            stringArray += $"\"{sourceArray[i]}\"";
            break;
        }
        stringArray += ($"\"{sourceArray[i]}\", ");
    }
    stringArray += "]";
    return stringArray;
}

int CountStringSymbols(string[] sourceArray)
{
    int counter = 0;
    foreach (string item in sourceArray)
    {
        if (item.Length <= 3)
        {
            counter++;
        }
    }
    return counter;
}

string[] GenerateNewArray(string[] sourceArray)
{
    int resultArrayLength = CountStringSymbols(sourceArray);
    string[] resultArray = new string[resultArrayLength];
    int i = 0;
    foreach (string item in sourceArray)
    {
        if (item.Length <= 3)
        {
            resultArray[i] = item;
            i++;
        }
    }
    return resultArray;
}
