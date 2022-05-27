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

namespace ex_008_001_if_else
{
    class Program
    {
        static void Main(string[] args)
        {
            int vitesseMax = 70;
            Console.WriteLine("La vitesse maximum autorisée est de {0} km/h", vitesseMax);
            Random random = new Random();
            int vitesse = random.Next(50, 150);
            Console.WriteLine("Vous roulez à {0} km/h", vitesse);

            if (vitesse <= vitesseMax)
            {
                Console.WriteLine("Vous ne dépassez pas la vitesse maximum");
            }
            else
            {
                Console.WriteLine("Vous dépassez la vitesse maximum autorisée");
                if (vitesse < vitesseMax + 20)
                {
                    Console.WriteLine("L'amende forfaitaire s'élève à 68 euros");
                    Console.WriteLine("1 point est retiré du permis de conduire");
                }
                else if (vitesse < vitesseMax + 50)
                {
                    Console.WriteLine("L'amende forfaitaire s'élève à 135 euros");
                    if (vitesse < vitesseMax + 30)
                    {
                        Console.WriteLine("2 points sont retirés du permis de conduire");
                    }
                    else if (vitesse < vitesseMax + 40)
                    {
                        Console.WriteLine("3 points sont retirés du permis de conduire");
                    }
                    else if (vitesse < vitesseMax + 50)
                    {
                        Console.WriteLine("4 points sont retirés du permis de conduire");

                    }
                }
                else
                {
                    Console.WriteLine("L'amende fofaitaire s'élève à 1500 euros");
                    Console.WriteLine("6 points sont retirés du permis de conduire");
                }
                if (vitesse >= vitesseMax + 30)
                {
                    Console.WriteLine("Jusqu'à 3 ans de suspension de permis de conduire");
                    if (vitesse >= vitesseMax + 40)
                    {
                        if (vitesse >= vitesseMax + 50)
                        {
                            Console.WriteLine("Obligation d'accomplir, à ses frais, un stage de sensibilisation à la sécurité routière, confiscation du véhicule dont le prévenu s'est servi pour commettre l'infraction, s'il en est propriétaire.");
                        }
                        Console.WriteLine("Une suspension immédiate du permis de conduire s'ajoute aux sanctions ci-dessus");
                    }
                }
            }
        }
    }
}
