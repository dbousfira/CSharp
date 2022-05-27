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

namespace ex_003_003_Main_arguments
{
    class Program
    {
        //les arguments sont passés dans un tableau de chaîne de caractères
        static void Main(string[] args)
        {
            Console.WriteLine("Coucou le monde !");
            
            //on peut en savoir le nombre en utilisant la propriété Length
            //ici, {0} sera remplacé par la valeur de args.Length
            Console.WriteLine("Vous avez passé {0} argument(s).", args.Length);

            Console.WriteLine("Voici les arguments que vous avez passés :");
            
            //foreach permet de parcourir les éléments de ce tableau d'arguments
            foreach (string arg in args)
            {
                // \t permet d'insérer une tabulation
                //ici, {0} sera remplacé par la valeur de arg
                Console.WriteLine("\t{0}", arg);
            }
        }
    }
}
