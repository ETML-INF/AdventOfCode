using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Program
{
    static void Main()
    {
        string inputFilePath = "input.txt";

        string[] lines = File.ReadAllLines(inputFilePath);

        List<int> elfCalories = new List<int>();
        int currentElfCalories = 0;

        foreach (string line in lines)
        {
            if (string.IsNullOrWhiteSpace(line))
            {
                elfCalories.Add(currentElfCalories);
                currentElfCalories = 0; 
            }
            else
            {

                if (int.TryParse(line, out int calories))
                {
                    currentElfCalories += calories;
                }
            }
        }

        if (currentElfCalories > 0)
        {
            elfCalories.Add(currentElfCalories);
        }


        elfCalories.Sort();
        elfCalories.Reverse(); 


        int topThreeCalories = elfCalories.Take(3).Sum();

        Console.WriteLine($"The total Calories carried by the top three Elves is: {topThreeCalories}");
    }
}