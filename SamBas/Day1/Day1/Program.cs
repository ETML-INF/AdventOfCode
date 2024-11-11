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
            calories = File.ReadAllLines("../../../inputB.txt");
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
            //Console.WriteLine(totalCalories.Max());
            int sumTopThreeElves = 0;
            List<int> listTotalCalories = new List<int>();
            listTotalCalories = totalCalories.ToList();
            //sort and order the list in desc order
            listTotalCalories.Sort();
            listTotalCalories.Reverse();
            //write tj^he list
            //foreach (int i in listTotalCalories)
            //{
            //    Console.WriteLine(i);
            //}
            for (int i = 0;i < 3;i++)
            {
                sumTopThreeElves += listTotalCalories[i];
            }
            Console.WriteLine("\n\n Top three cals: "+ sumTopThreeElves);
            Console.ReadLine();
        }
    }
}
