// ========================================================================
//
// Copyright (C) 2013-2014 MARC CHEVALDONNE
//                         marc.chevaldonne.free.fr
//
// Module        : Nounours.cs
// Author        : Marc Chevaldonné
// Creation date : 2014-04-13
//
// ========================================================================

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_031_001_decouverteDeLINQ
{
    class Nounours
    {
        public string Nom
        {
            get;
            private set;
        }

        public DateTime Naissance
        {
            get;
            private set;
        }

        public int NbPoils
        {
            get;
            private set;
        }

        public int Taille
        {
            get;
            private set;
        }

        public bool IsGentil
        {
            get;
            private set;
        }

        public bool IsToutDoux
        {
            get;
            private set;
        }

        public int Odeur
        {
            get;
            private set;
        }

        public Nounours(string nom, DateTime naissance, int nbPoils, int taille, bool isGentil, bool isToutDoux, int odeur)
        {
            Nom = nom;
            Naissance = naissance;
            NbPoils = nbPoils;
            Taille = taille;
            IsGentil = isGentil;
            IsToutDoux = isToutDoux;
            Odeur = odeur;
        }

        public static Nounours[] TousMesNounours = { new Nounours("Sinsin le singe", new DateTime(1987, 1, 1), 54, 35, true, false, 10),
                                                     new Nounours("Lapin le lapin", new DateTime(1997, 1, 1), 325, 85, true, true, 1),
                                                     new Nounours("Chucky la poupée de sang", new DateTime(1988, 1, 1), 13, 30, false, false, 5),
                                                     new Nounours("Popeye le marin", new DateTime(1929, 1, 1), 0, 165, true, false, 0),
                                                     new Nounours("Gizmo le mogwai", new DateTime(1984, 1, 1), 3678, 25, true, true, 2),
                                                     new Nounours("LaCrête le gremlin", new DateTime(1984, 1, 1), 5, 35, false, false, 10),
                                                     new Nounours("Caillou", new DateTime(1997, 1, 1), 0, 95, false, false, 4),
                                                     new Nounours("Olivier", new DateTime(1993, 1, 1), 4, 154, true, true, 0),
                                                     new Nounours("José l'ours polaire", DateTime.Now, 8, 212, false, true, 7) };
    }
}
