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

namespace ex_003_004_Console
{
    class Program
    {
        static void Main(string[] args)
         {
            Console.WriteLine("Voici un exemple d'utilisation de la console");

            //utilisation de Write, qui écrit dans la Console, mais ne va pas à la ligne
            Console.Write("Avec Write, je ne vais pas à la ligne, ");

            //WriteLine, écrit dans la Console, puis va à la ligne
            Console.WriteLine("mais avec Write Line, si.");

            //toutes les variables peuvent être transformées en chaîne de caractères,
            //car chaque type possède une méthode ToString() qui le transforme en chaîne de caractères.
            //Dans le cas des types que vous créerez vous-même, vous devrez écrire cette méthode ToString,
            //car la méthode par défaut ne vous conviendra pas souvent.
            //Dans le cas des types .NET, vous pouvez l'utiliser directement, car elle toujours réécrite.
            //Lorsque vous voulez afficher une variable dans la Console à l'aide de Write ou WriteLine,
            //vous pouvez appeler explicitement ce ToString, ou ne rien faire, dans ce cas, ToString est appelée
            //de manière implicite.
            Console.WriteLine("Je peux aussi écrire le contenu de variables : ");
            int a = 2;
            //les deux lignes suivantes font exactement la même chose (la première est juste plus simple)
            Console.WriteLine(a);
            Console.WriteLine(a.ToString());
            int b = 3;
            int c = a + b;
            //dans la ligne suivante, le compilateur fait a.ToString() + " + " b.ToString() + " = " + c.ToString()
            //car il commence par le premier + : a + " + "
            //Lorsque le compilateur cherche à ajouter un entier à une chaîne de caractères, il transforme l'entier en chaîne de caractères
            //puis concatène les deux.
            //Il obtient donc la chaîne de caractères "2 + ", puis passe à la seconde opération : une chaîne de caractères + un entier
            //Il transforme donc l'entier en chaîne de caractères et les concatène, etc...
            Console.WriteLine(a + " + " + b + " = " + c);
            //Autre manière plus simple de l'écrire, et plus efficace, en utilisant un string.Format implicite
            //(qui sera présenté plus tard)
            Console.WriteLine("{0} + {1} = {2}", a, b, c);

            //à partir de ce que vous avez vu dans l'exemple précédent, essayez de déterminer le résultat des affichages suivants :
            Console.WriteLine("petit truc marrant :");
            Console.WriteLine(a + b + " = Somme");
            Console.WriteLine("Somme = " + a + b);
            //le premier donne "5 = Somme" et le deuxième donne "Somme = 23"
            //Dans le premier cas, le compilateur s'occupe du premier + : a + b 
            //a et b sont deux entiers, il ajoute donc deux entiers : 2 + 3 = 5
            //puis il ajoute un entier (5) et une chaîne de caractères " = Somme"
            //Il transforme donc l'entier en chaîne de caractères puis les concatène : "5 = Somme"
            //Dans le deuxième cas, il ajoute d'abord une chaîne de caractères "Somme = " et un entier a
            //Il transforme donc l'entier en chaîne de caractères et les concatène, soit "Somme = " + "2" = "Somme = 2"
            //Il ajoute ensuite une chaîne de caractères "Somme = 2" et un entier b
            //Il transforme donc l'entier en chaîne de caractères "3" et les concatène : "Somme = 2" + "3" = "Somme = 23"

            Console.WriteLine("Ecrivez du texte puis appuyez sur Entrée");
            //pour lire le texte entré par l'utilisateur
            string s = Console.ReadLine(); //lit jusqu'à l'appui sur ENTREE
            Console.WriteLine("Vous avez écrit : {0}", s);
            //attend l'appui sur une touche
            Console.ReadKey(true);



            //on peut changer la couleur de fond
            Console.BackgroundColor = ConsoleColor.DarkBlue;

            //on peut changer la couleur du texte
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("sympa mais vite illisible :)");

            //on peut faire des beep
            Console.Beep();


            //on peut obtenir des informations sur la Console, comme sa taille par exemple
            Console.WriteLine("La fenêtre Console mesure {0} caractères de haut et {1} caractères de large", Console.WindowHeight, Console.WindowWidth);

            //On peut effacfer le contenu de la Console avec Clear
            Console.WriteLine("Appuyez sur une touche pour effacer le contenu de la Console");
            Console.ReadKey(true);
            Console.Clear();
        }
    }
}
