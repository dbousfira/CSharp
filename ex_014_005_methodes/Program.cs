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

namespace ex_014_005_methodes
{
    internal class Disque
    {
        //une méthode est définie juste après sa déclaration
        //elle peut avoir aussi les modifieurs public, protected, private, internal
        //elle peut être surchargée, tant que les paramètres sont différents (ref et out comptent)
        public void Affiche()
        {
            Console.WriteLine("Affiche()");
        }
        public void Affiche(int bof)
        {
            Console.WriteLine("Affiche(int bof)");
        }
        public void Affiche(ref int bof)
        {
            Console.WriteLine("Affiche(ref int bof)");
        }

        //constructeurs 
        //une classe peut avoir un ou plusieurs constructeurs, qui peuvent s'appeler à l'aide du mot clé this
        //le constructeur sans paramètre est le constructeur par défaut
        public Disque()
        {
        }
    }

    class Artiste
    {
        //rien pour l'instant...
    }

    class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            Disque d = new Disque();
            d.Affiche();
            d.Affiche(a);
            d.Affiche(ref a);
        }
    }
}
