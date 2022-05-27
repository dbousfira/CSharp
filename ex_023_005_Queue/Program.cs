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

namespace ex_023_005_Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<string> queue = new Queue<string>();
            queue.Enqueue("client 1");
            queue.Enqueue("client 2");
            queue.Enqueue("client 3");
            queue.Enqueue("client 4");
            Console.WriteLine("ToArray");
            string[] tab = queue.ToArray();
            foreach (string s in tab) Console.WriteLine(s);

            Console.WriteLine("Count");
            Console.WriteLine(queue.Count);
            Console.WriteLine("Peek"); // prend le prochain élément qui sortira, sans le sortir
            Console.WriteLine(queue.Peek());
            Console.WriteLine("Dequeue"); // sort le prochain élément et le rend
            Console.WriteLine(queue.Dequeue());
            Console.WriteLine(queue.Dequeue());
            Console.WriteLine(queue.Dequeue());
            Console.WriteLine(queue.Dequeue());
            Console.WriteLine(queue.Dequeue()); //exception

        }

    }
}
