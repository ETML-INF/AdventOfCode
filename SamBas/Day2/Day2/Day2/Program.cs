using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Day2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int loseScore = 0;
            const int drawScore = 3;
            const int winScore = 6;

            const int rockValue = 1;
            const int paperValue = 2;
            const int ScissorsScore = 3;

            string[] input;
            input = File.ReadAllLines("../../../inputB.txt");


            //pour chaque ligne: 
            //- trouver ce que l'aderversaire joue
            //- trouver ce qu'on doit jouer
            //- trouver si victoire/défaite/égalité
            //- calculer le score
            //- ajouter le score au score final
            for (int i = 0; i < input.Length; i++)
            {
                 string line = input[i];
                 
            }
        }
    }
}
