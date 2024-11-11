using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

int x = 0;
int y = 0;


string[] lines = {



};

string[] input = {
            "forward 1", "down 5", "down 4", "down 5", "forward 4", "down 3", "up 8",
            "forward 7", "down 2", "up 6", "forward 4", "forward 8", "forward 8",
            "up 7", "down 2", "down 7", "down 9", "forward 8", "down 9", "down 5",
            "forward 8", "forward 6", "up 4", "up 7", "down 7", "forward 1", "up 2",
            "forward 1", "down 6", "down 1", "forward 9", "forward 8", "up 4", "forward 9",
            "up 7", "forward 8", "forward 1", "down 6", "up 3", "forward 2", "down 6",
            "up 3", "up 5", "forward 6", "up 5", "down 9", "forward 4", "up 5",
            "down 3", "forward 5", "forward 2", "up 6", "up 1", "up 4", "forward 5",
            "down 5", "forward 8", "up 3", "down 8", "forward 2"
        };

int horizontalPosition = 0;
int depth = 0;

foreach (string command in input)
{
    string[] parts = command.Split(' ');
    string action = parts[0];
    int value = int.Parse(parts[1]);

    switch (action)
    {
        case "forward":
            x += value;
            break;
        case "down":
            y += value;
            break;
        case "up":
            y -= value;
            break;
    }
}



Console.WriteLine($"x:{x}   y:{y}");