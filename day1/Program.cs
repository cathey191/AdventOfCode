using System;

class Day1
{
    static void Main () {
        string[] input = System.IO.File.ReadAllLines(@"part1Input.txt");
		int[] depth = Array.ConvertAll(input, int.Parse);
		int count = 0;

        for (int i = 1; i < depth.Length - 2; i++)
        {
			int firstThree = depth[i - 1] + depth[i] + depth[i + 1];
			int secondThree	= depth[i] + depth[i + 1] + depth[i + 2];

            if (secondThree > firstThree) 
			{
				count++;
			}
        }

        System.Console.WriteLine("Result = " + count);
    }
}
