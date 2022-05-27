// ========================================================================
//
// Copyright (C) 2013-2014 MARC CHEVALDONNE
//                         marc.chevaldonne.free.fr
//
// Module        : Program.cs
// Author        : Marc Chevaldonné
// Creation date : 2014-03-30
//
// ========================================================================

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_005_003_tableaux_multiDimensions
{
    class Program
    {
        static void Main(string[] args)
        {
            //TABLEAUX A PLUSIEURS DIMENSIONS
            int[,] mat = new int[2, 3]; //2 lignes et 3 colonnes
            int[,] mat2 = { { 1, 2, 3 }, { 4, 5, 6 } };
            int[, ,] tab10;//3 dimensions
            //pour copier, on peut utiliser la méthode Clone
            //parcours d'un tableau à plusieurs dimensions
            Console.WriteLine("\nTABLEAUX A DEUX DIMENSIONS");
            for (int ligne = 0; ligne < mat2.GetLength(0); ligne++)
            {
                for (int colonne = 0; colonne < mat2.GetLength(1); colonne++)
                {
                    Console.Write("{0} ", mat2[ligne, colonne]);
                }
                Console.WriteLine();
            }

            //TABLEAUX EPARSES
            int[][] jagged = new int[3][];//tableaux à trois lignes de tailles différentes
            jagged[0] = new int[2];
            jagged[0][0] = 10;
            jagged[0][1] = 20;
            jagged[1] = new int[4];
            jagged[1][0] = 30;
            jagged[1][1] = 40;
            jagged[1][2] = 50;
            jagged[1][3] = 60;
            jagged[2] = new int[3];
            jagged[2][0] = 70;
            jagged[2][1] = 80;
            jagged[2][2] = 90;
            Console.WriteLine("\nTABLEAUX EPARSES");
            for (int ligne = 0; ligne < jagged.GetLength(0); ligne++)
            {
                for (int colonne = 0; colonne < jagged[ligne].Length; colonne++)
                {
                    Console.Write("{0} ", jagged[ligne][colonne]);
                }
                Console.WriteLine();
            }
            //initialisation directe
            int[][] jagged2 = new int[][]
                              {
                                  new int[] {10, 20},
                                  new int[] {30, 40, 50, 60},
                                  new int[] {70, 80, 90}
                              };

            
        }
    }
}
