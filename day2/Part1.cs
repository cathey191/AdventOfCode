using System;

class Day2
{
    static void Main()
    {
        string[] input = System.IO.File.ReadAllLines(@"input.txt");
        int hor = 0;
        int depth = 0;

        for (int i = 0; i < input.Length; i++)
        {
            if (input[i].Contains("forward"))
            {
                int num = input[i][input[i].Length - 1] - '0';
                hor = hor + num;
            } 
            else if (input[i].Contains("down"))
            {
                int num = input[i][input[i].Length - 1] - '0';
                depth = depth + num;
            }
            else if (input[i].Contains("up"))
            {
                int num = input[i][input[i].Length - 1] - '0';
                depth = depth - num;
            }
        }

        int result = hor * depth;
        System.Console.WriteLine("Result = " + result);
    }
}