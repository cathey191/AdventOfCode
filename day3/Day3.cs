using System;

class Day3
{
    static void Main()
    {
        string[] input = System.IO.File.ReadAllLines(@"input.txt");
        string gamma = "";
        string epsilon = "";

        for (int i = 0; i < input[0].Length; i++)
        {
            int zeroCount = 0;
            int oneCount = 0;
            
            for (int j = 0; j < input.Length; j++)
            {
                if (input[j][i].Equals('0'))
                {
                    zeroCount++;
                }
                else
                {
                    oneCount++;
                }
            }

            if (zeroCount > oneCount)
            {
                gamma = gamma + "0";
                epsilon = epsilon + "1";
            }
            else
            {
                epsilon = epsilon + "0";
                gamma = gamma + "1";
            }
        }

        int gammaInt = Convert.ToInt32(gamma, 2);
        int epsilonInt = Convert.ToInt32(epsilon, 2);
        int result = gammaInt * epsilonInt;
        
        System.Console.WriteLine("Result = " + result);
    }
}