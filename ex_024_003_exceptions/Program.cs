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

namespace ex_024_003_exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            //exemple 1
            try
            {
                Console.WriteLine("avant division : ");
                int a = 10, b = 0;
                int c = a / b;
                Console.WriteLine("après division");
            }
            catch (Exception exc)
            {
                Console.WriteLine("erreur de division par 0");
            }

            ////exemple 2
            try
            {
                Console.WriteLine("avant d'accéder au tableau");
                int[] tab = { 1, 2, 3 };
                int d = tab[3];
                Console.WriteLine("après");
            }
            catch (Exception exc)
            {
                Console.WriteLine("erreur d'accès au tableau");
            }

            //exemple 3
            //try
            //{
            //    Console.WriteLine("début");
            //    int[] tab = { 1, 2, 3 };
            //    int a = 10, b = 1;
            //    tab[3] = a / b;
            //    Console.WriteLine("après");
            //}

            //catch (ArithmeticException exc)
            //{
            //    Console.WriteLine("erreur sur opération arithmétique");
            //}
            //catch (IndexOutOfRangeException exc)
            //{
            //    Console.WriteLine("erreur d'accès à un tableau");
            //}
            //catch (Exception exc)
            //{
            //    Console.WriteLine("je crois que nous avons un problème");
            //}
            //finally
            //{
            //    Console.WriteLine("fin des tests");
            //}
        }
    }
}
