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

namespace ex_031_003_anonymousTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            var nounours = new { Nom = "Boule de poils", Age = 5 };

            //équivalent à :

            /*
             * internal class TypeAnonymeGénéré
             * {
             *      private string name;
             *      private int age;
             *      
             *      public TypeAnonymeGénéré (string name, int age)
             *      {
             *          this.name = name;
             *          this.age = age;
             *      }
             *      
             *      public string Nom 
             *      { 
             *          get 
             *          { 
             *              return name; 
             *          } 
             *      } 
             *       
             *      public int Age
             *      {
             *          get
             *          {   
             *              return age;
             *          }
             *      }
             *      
             *      //Equals, GetHashCode, ToString réécrites
             * }
             * ...
             * var nounours = new TypeAnonymeGénéré("Boule de poils", 5);
             * */

            //un exemple où c'est bien pratique :
            string[] bestioles = { "serpent", "chat", "éléphant", "chien", "étudiant", "souris", "singe", "bisounours", "hydralisk", "macaque", "cheval" };
            var result = bestioles.Select(bestiole => new { Nom = bestiole, Taille = bestiole.Length, Première_Lettre = bestiole[0] });
            foreach (var r in result)
            {
                Console.WriteLine(r.Nom + " (" + r.Taille + " lettres) /" + r.Première_Lettre.ToString().ToUpper() + "/");
            }
        }
    }
}
