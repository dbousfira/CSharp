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

namespace ex_014_004_constructeurs
{
    internal class Disque
    {
        int mNombre = 1;

        readonly string mMaisonDeDisque = "IUT";

        //constructeurs 
        //une classe peut avoir un ou plusieurs constructeurs, qui peuvent s'appeler à l'aide du mot clé this
        //le constructeur sans paramètre est le constructeur par défaut
        public Disque()
        {
        }
        public Disque(string maison_de_disque)
        {
            mMaisonDeDisque = maison_de_disque;
        }
        public Disque(string maison_de_disque, int nombre)
            : this(maison_de_disque)
        {
            mNombre = nombre;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Disque d = new Disque();
            Disque d2 = new Disque("Oh yes !");
            Disque d3 = new Disque("Arf no !", 0);
        }
    }
}
