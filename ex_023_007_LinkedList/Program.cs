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

namespace ex_023_007_LinkedList
{
    class Program
    {
        static void Display(LinkedList<string> notes)
        {
            Console.WriteLine("début");
            foreach (string s in notes)
            {
                Console.Write(s + " ");
            }
            Console.WriteLine();
            Console.WriteLine("fin");
        }

        static void Main(string[] args)
        {
            LinkedList<string> notes = new LinkedList<string>();

            Console.WriteLine("AddFirst, AddLast");
            notes.AddFirst("do");
            notes.AddLast("sol");
            Display(notes);

            Console.WriteLine("AddAfter, AddBefore, First, Next, Last");
            notes.AddAfter(notes.First, "re");
            notes.AddAfter(notes.First.Next, "mi");
            notes.AddBefore(notes.Last, "fa");
            Display(notes);

            Console.WriteLine("RemoveFirst, RemoveLast");
            notes.RemoveFirst();
            notes.RemoveLast();
            Display(notes);

            Console.WriteLine("manipulation de nodes");
            LinkedListNode<string> mi = notes.Find("mi");
            notes.Remove(mi);
            notes.AddFirst(mi);
            Display(notes);
        }
    }
}
