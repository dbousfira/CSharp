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

namespace ex_023_006_Stack
{
    class Program
    {
        static void Display(Stack<int> stack)
        {
            Console.Write("stack :");
            foreach (int i in stack) Console.Write(i + " ");
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>();
            stack.Push(1); Display(stack);
            stack.Push(2); Display(stack);
            stack.Push(3); Display(stack);
            Console.WriteLine(stack.Count);
            Console.WriteLine(stack.Peek()); Display(stack);
            Console.WriteLine(stack.Pop()); Display(stack);
            Console.WriteLine(stack.Pop()); Display(stack);
            Console.WriteLine(stack.Pop()); Display(stack);
            Console.WriteLine(stack.Pop()); Display(stack);



        }
    }
}
