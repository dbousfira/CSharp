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

namespace ex_015_001_static
{
    public class Etudiant
    {
        Random random = new Random();

        public int GenereNoteAvecRandomNonStatic()
        {
            return random.Next(0,21);
        }

        static Random randomStatic;

        public int GenereNoteAvecRandomStatic()
        {
            return randomStatic.Next(0, 21);
        }

        //un constructeur static est nécessairement privé et ne peut pas être appelé directement
        //il sera appelé lors de la première construction d'un objet de ce type
        static Etudiant()
        {
            randomStatic = new Random();
            //ici, il est évidemment préférable d'utiliser l'initialiseur plutôt que le constructeur pour Random
            //mais c'est juste pour l'exemple d'un constructeur static
        }

        //membre non statique
        public string Année = "2013-2014";

        //méthode non statique
        public string GetAnnéeFormation()
        {
            //une méthode non statique peut utiliser aussi bien des membres non statiques que des membres statiques
            return string.Format("{0} ({1})", Formation, Année);
        }

        //membre statique (partagé par toutes les instances de cette classe)
        public static string Formation = "DUT Informatique";

        //méthode statique
        public static string GetFormation()
        {
            //une méthode statique ne peut pas utiliser de membres non statiques 
            //return string.Format("{0} ({1})", Formation, Année);

            //une méthode statique ne peut utiliser que des membres statiques
            return string.Format("{0} ({1})", Formation, Université);
        }

        //un membre const est toujours statique, même si on ne le précise pas dans la syntaxe
        public const string Université = "Université d'Auvergne";
    }

    class Program
    {
        static void Main(string[] args)
        {
            Etudiant[] tableauEtudiants = new Etudiant[10];
            for(int i = 0; i<tableauEtudiants.Length; i++)
            {
                tableauEtudiants[i] = new Etudiant();
            }

            Console.WriteLine("Méthode avec random non static");
            for(int i = 0; i<tableauEtudiants.Length; i++)
            {
                Console.WriteLine("L'étudiant {0} a obtenu la note de {1}/20", i, tableauEtudiants[i].GenereNoteAvecRandomNonStatic());
            }
            Console.WriteLine();

            Console.WriteLine("Méthode avec random static");
            for (int i = 0; i < tableauEtudiants.Length; i++)
            {
                Console.WriteLine("L'étudiant {0} a obtenu la note de {1}/20", i, tableauEtudiants[i].GenereNoteAvecRandomStatic());
            }
            Console.WriteLine();

            Console.WriteLine("Année");
            //pour appeler les membres non statiques et les méthodes non statiques,
            //une instance est obligatoire
            Etudiant étudiant = new Etudiant();
            Console.WriteLine(étudiant.Année);
            Console.WriteLine(étudiant.GetAnnéeFormation());
            Console.WriteLine();

            Console.WriteLine("Formation");
            //pour appeler les membres statiques et les méthodes statiques,
            //on utiliser les méthodes sur le type lui-même, sans instances
            Console.WriteLine(Etudiant.Formation);
            Console.WriteLine(Etudiant.GetFormation());
            Console.WriteLine();

            Console.WriteLine("Autre exemple de propriété statique : DateTime.Now");
            Console.WriteLine("DateTime.Now = {0}", DateTime.Now);
        }
    }
}
