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

namespace ex_024_005_exceptions
{
    class MyException : Exception
    {
        public MyException(string msg) : base(msg) { }
    }

    class Program
    {
        static void GetPlayerNames()
        {
            Console.WriteLine("Rentrez le nom du premier joueur");
            string player1 = Console.ReadLine();
            Console.WriteLine("Rentrez le nom du deuxième joueur");
            string player2 = Console.ReadLine();

            if (player1 == player2)
            {
                throw new MyException("Les deux joueurs doivent avoir des noms différents");
            }
        }

        static void Main(string[] args)
        {
            try
            {
                GetPlayerNames();
            }
            catch (MyException exc)
            {
                Console.WriteLine(exc.Message);
            }
            Console.WriteLine("pas de jeu en fait...");
        }
    }
}
