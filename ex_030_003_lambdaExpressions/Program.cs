// ========================================================================
//
// Copyright (C) 2013-2014 MARC CHEVALDONNE
//                         marc.chevaldonne.free.fr
//
// Module        : Program.cs
// Author        : Marc Chevaldonné
// Creation date : 2014-04-13
//
// ========================================================================

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using nsUtils;

namespace ex_030_003_lambdaExpressions
{
    class Program
    {
        //ex_04_009 avec des expressions lambda
        static void Main(string[] args)
        {
            ClasseQuiFaitDuGrosTravail travail = new ClasseQuiFaitDuGrosTravail();
            travail.GrosTravail();
            Console.WriteLine("fini");

            //on prépare une instance de délégué du type délégué Progression pointant sur une seule expression lambda,
            //et on appelle la méthode GrosTravail avec cette instance en paramètre.
            Console.WriteLine("PREMIER APPEL");
            ClasseQuiFaitDuGrosTravail.Progression affiche = pourcentage => Console.WriteLine(pourcentage + "% effectués...");
            travail.Attacher(affiche);
            travail.GrosTravail();

            //on ajoute une instance de délégué à notre "pointeur" : une autre expression lambda.
            //L'instance de délégué p pointe maintenant sur deux méthodes qui sont exécutées l'une après l'autre à chaque appel.
            //On appelle la méthode GrosTravail avec cette instance en paramètre.
            Console.WriteLine("DEUXIEME APPEL");
            travail.Attacher(pourcentage => Console.WriteLine(String.Empty.PadLeft(pourcentage * (Console.WindowWidth - 1) / 100, '*')));
            travail.GrosTravail();

            //on retire une instance de délégué à notre "pointeur", mais ce n'est plus possible avec les méthodes anonymes, même si on retape la même !
            Console.WriteLine("TROISIEME APPEL");
            travail.Détacher(affiche);
            travail.GrosTravail();

            //on réinitialise p avec une nouvelle expression lambda, puis on en ajoute 2 autres
            travail.Initialiser(pourcentage => Console.Clear());
            travail.Attacher(pourcentage => Console.WriteLine(String.Empty.PadLeft(pourcentage * (Console.WindowWidth - 1) / 100, '*')));
            travail.Attacher(pourcentage => Console.WriteLine(pourcentage + "% effectués..."));
            travail.GrosTravail();
        }
    }
}
