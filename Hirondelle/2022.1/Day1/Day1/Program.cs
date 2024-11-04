using System;
using System.Collections.Generic;
using System.IO;

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

        int maxCalories = 0;
        if (elfCalories.Count > 0)
        {
            maxCalories = Math.Max(maxCalories, elfCalories.Max());
        }

        Console.WriteLine($"The Elf carrying the most Calories has: {maxCalories}");
    }
}