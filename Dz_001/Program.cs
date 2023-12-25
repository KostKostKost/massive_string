using System;

class Program
{
    static void Main()
    {
        char[,] charArray = {
            {'H', 'e', 'l', 'l', 'o'},
            {'W', 'o', 'r', 'l', 'd'}
        };

        PrintCharArray(charArray);

        string resultString = ConvertCharArrayToString(charArray);

        Console.WriteLine("Строка из символов массива:");
        Console.WriteLine(resultString);
    }

static string ConvertCharArrayToString(char[,] charArray)
    {


        int rows = charArray.GetLength(0);
        int cols = charArray.GetLength(1);

        System.Text.StringBuilder sb = new System.Text.StringBuilder();

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                sb.Append(charArray[i, j]);
            }
        }

        return sb.ToString();
    }

    static void PrintCharArray(char[,] charArray)
    {
        int rows = charArray.GetLength(0);
        int cols = charArray.GetLength(1);

        Console.WriteLine("Двумерный массив символов:");

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write(charArray[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}
