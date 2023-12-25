using System;

class Program
{
    static void Main()
    {

        string inputString = "level";
        bool isPalindrome = IsPalindrome(inputString);
        Console.WriteLine($"Строка '{inputString}' является палиндромом: {isPalindrome}");
    }

    static bool IsPalindrome(string str)
    {
        str = str.Replace(" ", "").ToLower();

        int length = str.Length;
        for (int i = 0; i < length / 2; i++)
        {
            if (str[i] != str[length - i - 1])
            {
                return false;
            }
        }

        return true;
    }
}
