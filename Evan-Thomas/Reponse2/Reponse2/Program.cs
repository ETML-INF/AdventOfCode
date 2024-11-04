using System;
using System.Collections.Generic;

class Program
{
    // Définition des scores pour chaque forme
    static readonly Dictionary<char, int> shapeScores = new Dictionary<char, int>
    {
        {'X', 1}, // Rock
        {'Y', 2}, // Paper
        {'Z', 3}  // Scissors
    };

    // Définition des scores pour les résultats
    static readonly Dictionary<string, int> outcomeScores = new Dictionary<string, int>
    {
        {"win", 6},
        {"draw", 3},
        {"loss", 0}
    };

    // Règles des résultats en fonction des mouvements
    static readonly Dictionary<(char, char), string> outcomes = new Dictionary<(char, char), string>
    {
        {('A', 'X'), "draw"},  // Rock vs Rock
        {('A', 'Y'), "win"},   // Rock vs Paper
        {('A', 'Z'), "loss"},  // Rock vs Scissors
        {('B', 'X'), "loss"},  // Paper vs Rock
        {('B', 'Y'), "draw"},  // Paper vs Paper
        {('B', 'Z'), "win"},   // Paper vs Scissors
        {('C', 'X'), "win"},   // Scissors vs Rock
        {('C', 'Y'), "loss"},  // Scissors vs Paper
        {('C', 'Z'), "draw"}   // Scissors vs Scissors
    };

    static void Main()
    {
        // Liste des mouvements, chaque entrée est un tuple (mouvementAdversaire, mouvementJoueur)
        var rounds = new List<(char opponentMove, char playerMove)>
        {
            ('B', 'Z'), ('A', 'X'), ('B', 'Z'), ('B', 'Z'), ('C', 'Z'),
            ('B', 'Z'), ('A', 'Z'), ('B', 'X'), ('C', 'Y'), ('C', 'Y'),
            // Ajouter le reste des rounds ici
        };

        int totalScore = 0;

        foreach (var (opponentMove, playerMove) in rounds)
        {
            int shapeScore = shapeScores[playerMove];
            string outcome = outcomes[(opponentMove, playerMove)];
            int outcomeScore = outcomeScores[outcome];
            int roundScore = shapeScore + outcomeScore;
            totalScore += roundScore;
        }

        Console.WriteLine("Total Score: " + totalScore);
    }
}
