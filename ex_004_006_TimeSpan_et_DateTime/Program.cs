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

namespace ex_004_006_TimeSpan_et_DateTime
{
    class Program
    {
        static void Main(string[] args)
        {
            //TimeSpan
            //construction d'une durée à partir d'un constructeur
            TimeSpan durée_d_un_cours = new TimeSpan(1, 50, 00);
            //construction d'une durée à partir d'un nombre de minutes (ou heures, ou secondes...)
            TimeSpan retard = TimeSpan.FromMinutes(21.20);
            //opération (addition, soustraction) de durées
            TimeSpan durée_du_cours_aujourd_hui = durée_d_un_cours + retard;
            //durée nulle
            TimeSpan durée_nulle = TimeSpan.Zero;
            //affichage d'une durée
            Console.WriteLine("Le cours d'aujourd'hui est de {0} + {1} de retard = {2}", durée_d_un_cours, retard, durée_du_cours_aujourd_hui);
            Console.WriteLine();

            //DateTime
            //construction d'un DateTime
            DateTime débutDeJazzEnTete2012 = new DateTime(2012, 10, 23, 20, 00, 00);
            DateTime finDeJazzEnTete2012 = new DateTime(2012, 10, 27, 23, 59, 00);
            //soustraction de DateTime
            TimeSpan duréeDeJazzEnTete2012 = finDeJazzEnTete2012.Subtract(débutDeJazzEnTete2012);
            //affichage de DateTime
            Console.WriteLine("Le festival jazz en tête a duré : {0}", duréeDeJazzEnTete2012);
            Console.WriteLine("Le festival jazz en tête a duré : {0} jours et {1} heures", duréeDeJazzEnTete2012.Days, duréeDeJazzEnTete2012.Hours);
            Console.WriteLine("Le festival jazz en tête a duré : {0} jours et {1} heures", duréeDeJazzEnTete2012.Days, 
                Math.Round(duréeDeJazzEnTete2012.TotalHours-(duréeDeJazzEnTete2012.Days*24)));
            //on peut ajouter ou soustraire du temps à 1 DateTime
            DateTime débutDernierConcert = finDeJazzEnTete2012 - TimeSpan.FromHours(4);
            //autre solution équivalente
            débutDernierConcert = finDeJazzEnTete2012.Subtract(TimeSpan.FromHours(4));
            Console.WriteLine("Le dernier concert de Jazz en Tete commence le : {0} à {1}", débutDernierConcert.ToShortDateString(), débutDernierConcert.ToShortTimeString() );

            Console.WriteLine();

            //gestion des décalages horaires
            DateTime début_de_la_finale_de_l_USOpen = new DateTime(2010, 09, 13, 20, 00, 00, DateTimeKind.Utc);
            Console.WriteLine("La finale commencera : " + début_de_la_finale_de_l_USOpen.ToLocalTime().ToString("f") + " chez nous");
            Console.WriteLine("La finale commencera : " + (début_de_la_finale_de_l_USOpen - TimeSpan.FromHours(4)).ToString("g") + " à New York");
            Console.WriteLine();

            //on peut parser une chaîne de caractères !
            string date_réjouissances = "jeudi 29 septembre 2011 13:30";
            Console.WriteLine("Convertir jeudi 29 septembre 2011 13:30 en DateTime ? oui bien sûr !");
            DateTime réjouissances = DateTime.Parse(date_réjouissances);
            Console.WriteLine(réjouissances);

            //la date et l'heure actuelles (au moment de l'exécution de la ligne)
            //est donnée par :
            DateTime maintenant = DateTime.Now;
            Console.WriteLine("Maintenant : {0}", maintenant);
        }
    }
}
