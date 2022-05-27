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

namespace ex_021_002_patternStrategy
{
    interface IStrategy
    {
        void Operation();
    }

    class StrategyA : IStrategy
    {
        public void Operation()
        {
            Console.WriteLine("Je fais le travail demandé en faisant \"wouf wouf\"");
        }
    }

    class StrategyB : IStrategy
    {
        public void Operation()
        {
            Console.WriteLine("Je fais le travail demandé en faisant \"miaou miaou\"");
        }
    }

    class Program
    {
        static IStrategy maStrategie;

        static void Main(string[] args)
        {
            Console.WriteLine("J'utilise la stratégie A pour faire le travail");

            maStrategie = new StrategyA();
            maStrategie.Operation();

            Console.WriteLine("J'utilise la stratégie B pour faire le travail");

            maStrategie = new StrategyB();
            maStrategie.Operation();
        }
    }
}
