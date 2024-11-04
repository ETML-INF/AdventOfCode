using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Day1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] max3;
            string[] calories;
            calories = File.ReadAllLines("../../../input.txt");
            int[] totalCalories = new int[calories.Length];
            int j = 0;
            for (int i = 0; i < calories.Length; i++)
            {
                if (calories[i] != "")
                {
                    totalCalories[j] += int.Parse(calories[i]);
                }
                else
                {
                    j++;
                }
            }
            Console.WriteLine(totalCalories.Max());
            totalCalories.OrderBy();
            Console.ReadLine();
        }
    }
}
