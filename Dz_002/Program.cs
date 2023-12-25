using System;

class Program
{
    static void Main()
    {

        string originalString = "HelloWorld";
        string resultString = ConvertToLowerCase(originalString);
        Console.WriteLine("Исходная строка: " + originalString);
        Console.WriteLine("Строка с заменой заглавных на строчные: " + resultString);
    }

    static string ConvertToLowerCase(string inputString)
    {
        return inputString.ToLower();
    }
}