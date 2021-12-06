using System;

class Day1
{
    static void Main () {
        string[] input = System.IO.File.ReadAllLines(@"part1Input.txt");
		int[] depth = Array.ConvertAll(input, int.Parse);
		int count = 0;

        for (int i = 1; i < depth.Length; i++)
        {
            if (depth[i] > depth[i - 1]) 
			{
				count++;
			}
        }

        System.Console.WriteLine("Result = " + count);
    }
}
