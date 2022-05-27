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

namespace ex_004_003_Random
{
    class Program
    {
        static void Main(string[] args)
        {
            //juste pour que la fenêtre soit plus large et que le texte soit en conséquence plus lisible
            Console.WindowWidth += 5 ;

            //Random crée une suite de nombre aléatoires en fonction d'une graine (seed)
            Random rdm1 = new Random(); //utilise l'heure actuelle pour créer le seed automatiquement
            //si vous relancez plusieurs fois le programme, le nombre va changer car l'heure varie.
            Console.WriteLine("rdm1 : {0} {1} {2} {3} {4}", rdm1.Next(20), rdm1.Next(20), rdm1.Next(20), rdm1.Next(20), rdm1.Next(20));

            Console.WriteLine();

            //utilise le seed donné en paramètre
            //la suite de nombres est donc toujours la même
            //si vous relancez plusieurs fois le programme, vous aurez toujours la même suite de nombres.
            //ce peut être utile pour recréer les mêmes conditions lors d'un debug
            Random rdm2 = new Random(102394753);
            Console.WriteLine("rdm2 : {0} {1} {2} {3} {4}", rdm2.Next(20), rdm2.Next(20), rdm2.Next(20), rdm2.Next(20), rdm2.Next(20));

            //différentes façons d'utiliser la classe Random
            Console.WriteLine("rdm1.Next() retourne un nombre entier aléatoire non négatif :\n{0}\n", rdm1.Next());
            Console.WriteLine("rdm1.Next(20) retourne un nombre entier aléatoire dans l'intervalle [0;20[ :\n{0}\n", rdm1.Next(20));
            Console.WriteLine("rdm1.Next(5,20) retourne un nombre entier aléatoire dans l'intervalle [5;20[ :\n{0}\n", rdm1.Next(5, 20));
            Console.WriteLine("rdm1.NextDouble() retourne un nombre réel aléatoire dans l'intervalle [0.0;1.0[ :\n{0}\n", rdm1.NextDouble());
        }
    }
}
