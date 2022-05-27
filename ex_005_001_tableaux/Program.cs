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

namespace ex_005_001_tableaux
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WindowHeight = Console.LargestWindowHeight;

            //DECLARATION ET ALLOCATION DYNAMIQUE DE LA MEMOIRE
            int[] tab; //tab est une référence. Ici, on sait juste que tab désignera un tableau d'entiers à 1 dimension. Ce n'est pas ici 
            //qu'on indique la taille. tab étant une référence, il est alloué sur la pile.

            tab = new int[3]; //maintenant on alloue la place en mémoire (ici pour 3 entiers) sur le tas.
            // Il s'agit donc d'une allocation dynamique

            // en une seule fois : 
            int[] tab2 = new int[3];


            //ALLOCATION DYNAMIQUE ET INITIALISATION EN MEME TEMPS 
            int[] tab3;
            tab3 = new int[] { 1, 2, 3, 4, 5 }; //on peut aussi spécifier directement les valeurs du tableau. Pas la peine donc de donner
                                                //la taille du tableau dans ce cas.

            //en une seule fois : 
            int[] tab4 = { 1, 2, 3, 4, 5 };

            //INITIALISATION AUTOMATIQUE
            int[] tab4b = new int[5];
            Console.WriteLine(tab4b[2]); // les types numériques sont initialisés à 0 automatiquement
            bool[] tab4c = new bool[100];
            Console.WriteLine(tab4c[53]); // les types bool sont initialisés automatiquement à false
            //tous les types références (classes et string par exemple sont initialisés à null)


            //LIBERATION DE LA MEMOIRE
            //la libération est automatique, on n'appelle pas delete.

            //ACCES AUX ELEMENTS DU TABLEAU
            //les accès aux cellules du tableau se font comme en C/C++
            int a = tab4[0]; //a vaut 1
            a = tab4[1];//a vaut 2
            a = tab4[2];//a vaut 3
            a = tab4[3];//a vaut 4
            a = tab4[4];//a vaut 5

            //CONTROLE DES ACCES EN DEHORS DU TABLEAU
            //les accès en dehors du tableau sont contrôlées par le runtime
            // et provoque des exceptions IndexOutOfRangeException
            try
            {
                Console.WriteLine(tab4[5]);
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("tab4[5] a provoqué une exception");
            }

            //TAILLE DU TABLEAU
            //la taille d'un tableau est donnée par la propriété Length
            Console.WriteLine("taille du tableau tab4 : {0}", tab4.Length);

            //PARCOURIR LES ELEMENTS D'UN TABLEAU
            //avec une boucle for
            Console.WriteLine("tab4 : ");
            for (int i = 0; i < tab4.Length; i++)
            {
                Console.WriteLine(tab4[i]);
            }
            //avec une boucle foreach
            foreach (var elt in tab4)
            {
                Console.WriteLine(elt);
            }

            //TABLEAU D'OBJECT
            //tableaux avec des cellules de types différents
            object[] tab5 = new object[3];
            tab5[0] = 12;       //contient un entier
            tab5[1] = 3.4f;     //contient un réel
            tab5[2] = "arf";    //contient une chaîne de caractères
            //pour déterminer ensuite le type :
            for (int i = 0; i < tab5.Length; i++)
            {
                Type type = tab5[i].GetType();
                string s = type.Name;
                Console.WriteLine(s);
            }
            //ou pour l'utiliser : 
            for (int i = 0; i < tab5.Length; i++)
            {
                if (tab5[i] is int)
                {
                    Console.WriteLine(tab5[i]);
                }
            }
        }
    }
}
