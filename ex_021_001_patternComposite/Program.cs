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

namespace ex_021_001_patternComposite
{
    interface IComponent
    {
        void Operation();
    }

    class Component : IComponent
    {
        public void Operation()
        {
            Console.WriteLine("Je suis un Component et je réalise mon opération");
        }
    }

    class Composite : IComponent
    {
        List<IComponent> mChildren = new List<IComponent>();

        public void AddRange(params IComponent[] children)
        {
            mChildren.AddRange(children);
        }

        public void Operation()
        {
            Console.WriteLine("Je suis un Composite et je débute mon opération");
            Console.WriteLine("Je suis un Composite et je fais travailler mes enfants");
            foreach (IComponent child in mChildren)
            {
                child.Operation();
            }
            Console.WriteLine("Je suis un Composite et j'ai terminé mon opération");
        }
    }

    class Program
    {
        //N6 ---> N5 ---> N4 --> N1
        //    |       |
        //    |       --> N2
        //    |
        //    --> N3
        static void Main(string[] args)
        {
            Component noeud1 = new Component();
            Component noeud2 = new Component();
            Component noeud3 = new Component();
            Composite noeud4 = new Composite();
            Composite noeud5 = new Composite();
            Composite noeud6 = new Composite();
            noeud6.AddRange(noeud5, noeud3);
            noeud5.AddRange(noeud4, noeud2);
            noeud4.AddRange(noeud1);

            noeud1.Operation();
            Console.ReadLine();
            Console.Clear();
            noeud4.Operation();
            Console.ReadLine();
            Console.Clear();
            noeud5.Operation();
            Console.ReadLine();
            Console.Clear();
            noeud6.Operation();
        }
    }
}
