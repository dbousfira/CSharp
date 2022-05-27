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

namespace ex_024_004_exceptions
{
    class Program
    {
        static void fonction()
        {
            string s1 = Console.ReadLine();
            string s2 = Console.ReadLine();
            string s3 = Console.ReadLine();
            int a, b, c;
            Int32.TryParse(s1, out a);
            Int32.TryParse(s2, out b);
            Int32.TryParse(s3, out c);
            int[] tab = { 1, 2, 3 };
            try
            {
                Console.WriteLine("début du try de fonction");
                tab[c] = a / b;
                Console.WriteLine("fin du groupe try de fonction");
            }

            //mettez ou enlevez les commentaires sur les catch pour voir les différences de résultats
            catch (ArithmeticException)
            {
                Console.WriteLine("ArithmeticException dans fonction");
                throw new ArithmeticException();
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("IndexOutOfRangeException dans fonction");
            }
            finally
            {
                Console.WriteLine("finally dans fonction");
            }
        }

        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("début du try de Main");
                fonction();
                Console.WriteLine("fin du groupe try de Main");
            }
            catch (ArithmeticException)
            {
                Console.WriteLine("ArithmeticException dans Main");
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("IndexOutOfRangeException dans Main");
            }
            finally
            {
                Console.WriteLine("finally dans Main");
            }
        }
    }
}
