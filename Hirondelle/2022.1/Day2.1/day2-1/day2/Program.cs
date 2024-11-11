var scores = new Dictionary<string, int>();
scores["X"] = 1;
scores["Y"] = 2;
scores["Z"] = 3;

var outcomes = new Dictionary<string, int>();
outcomes["AX"] = 3;
outcomes["AY"] = 6;
outcomes["AZ"] = 0;
outcomes["BX"] = 0;
outcomes["BY"] = 3;
outcomes["BZ"] = 6;
outcomes["CX"] = 6;
outcomes["CY"] = 0;
outcomes["CZ"] = 3;

int totalScore = 0;

using (var input = new StreamReader("input.txt"))
{
    string line = input.ReadLine();
    while (line != null)
    {
        string[] shapes = line.Split(' ');
        string opponentShape = shapes[0];
        string myShape = shapes[1];

        int score = scores[myShape] + outcomes[opponentShape + myShape];


        totalScore += score;

        line = input.ReadLine();
    }
}
Console.WriteLine(totalScore);