// ========================================================================
//
// Copyright (C) 2013-2014 MARC CHEVALDONNE
//                         marc.chevaldonne.free.fr
//
// Module        : Program.cs
// Author        : Marc Chevaldonné
// Creation date : 2014-04-27
//
// ========================================================================

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using nsUtils;

namespace ex_028_009_multicast_delegate
{
    class Program
    {
        /// <summary>
        /// méthode de type délégué Progression (elle prend un entier et ne renvoie rien) qui affiche le pourcentage de progression
        /// </summary>
        /// <param name="pourcentage">pourcentage de progression</param>
        static void AffichePourcentage(int pourcentage)
        {
            Console.WriteLine(pourcentage + "% effectués...");
        }

        /// <summary>
        /// méthode de type délégué Progression (elle prend un entier et ne renvoie rien) qui affiche des étoiles en fonction du pourcentage de progression
        /// </summary>
        /// <param name="pourcentage">pourcentage de progression</param>
        static void ProgressBar(int pourcentage)
        {
            Console.WriteLine(String.Empty.PadLeft(pourcentage * (Console.WindowWidth - 1) / 100, '*'));
        }

        static void Main(string[] args)
        {
            ClasseQuiFaitDuGrosTravail travail = new ClasseQuiFaitDuGrosTravail();
            travail.GrosTravail();
            Console.WriteLine("fini");

            //on prépare une instance de délégué du type délégué Progression pointant sur une seule méthode AffichePourcentage,
            //et on appelle la méthode GrosTravail avec cette instance en paramètre.
            Console.WriteLine("PREMIER APPEL");
            travail.Attacher(AffichePourcentage);
            travail.GrosTravail();

            //on ajoute une instance de délégué à notre "pointeur" : ProgressBar.
            //L'instance de délégué p pointe maintenant sur deux méthodes qui sont exécutées l'une après l'autre à chaque appel.
            //On appelle la méthode GrosTravail avec cette instance en paramètre.
            Console.WriteLine("DEUXIEME APPEL");
            travail.Attacher(ProgressBar);
            travail.GrosTravail();

            //on retire une instance de délégué à notre "pointeur" : AffichePourcentagen.
            //L'instance de délégué p pointe maintenant sur une seule méthode (ProgressBar).
            //On appelle la méthode GrosTravail avec cette instance en paramètre.
            Console.WriteLine("TROISIEME APPEL");
            travail.Détacher(AffichePourcentage);
            travail.GrosTravail();

            //on réinitialise p avec la méthode ClearConsole, puis on ajoute ProgressBar, puis AffichePourcentage
            travail.Initialiser(ClearConsole);
            travail.Attacher(ProgressBar);
            travail.Attacher(AffichePourcentage);
            travail.GrosTravail();
        }

        static void ClearConsole(int pourcentage)
        {
            Console.Clear();
        }
    }
}
