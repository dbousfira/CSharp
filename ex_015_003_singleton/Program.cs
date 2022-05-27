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

namespace ex_015_003_singleton
{
    //le patron de conception Singleton permet de restreindre le nombre d'instances à 1
    public class IutClermont
    {
        //le constructeur est privé et ne peut pas être appelé en dehors de la classe
        private IutClermont()
        {
            Description = "Meilleur IUT d'Informatique de France";
        }

        //membre non statique, utilisable par les instances
        public string Description;

        //la classe possède un membre statique du type de la classe qui lui, peut appeler le constructeur privé pour se construire
        static IutClermont mInstance = new IutClermont();

        //méthode statique de la classe, rendant l'instance statique de cette classe
        public static IutClermont GetInstance()
        {
            return mInstance;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //IutClermont iut = new IutClermont(); //interdit
            IutClermont iut = IutClermont.GetInstance();
            Console.WriteLine(iut.Description);
        }
    }
}
