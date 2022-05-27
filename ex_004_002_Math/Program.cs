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

namespace ex_004_002_Math
{
    class Program
    {
        static void Main(string[] args)
        {  
            //constantes de la classe Math :
            Console.WriteLine("CONSTANTES DE LA CLASSE MATH");
            //epsilon
            Console.WriteLine("E(e) : {0}", Math.E);
            //PI
            Console.WriteLine("Pi : {0}", Math.PI);

            Console.WriteLine();

            //méthodes pour arrondir
            Console.WriteLine("METHODES POUR ARRONDIR");
            //arrondir 
            Console.WriteLine("Arrondir 1,9876 à 2 chiffres après la virgule : {0}", Math.Round(1.9876, 2));
            //tronquer
            Console.WriteLine("Partie entière de 1,9876 : {0}", Math.Truncate(1.9876));
            //plus grand entier inférieur
            Console.WriteLine("Plus grand entier inférieur de 1,9876 : {0}", Math.Floor(1.9876));
            //plus petit entier supérieur
            Console.WriteLine("Plus petit entier supérieur de 1,9876 : {0}", Math.Ceiling(1.9876));

            Console.WriteLine();

            //calcul de maximums et minimums
            Console.WriteLine("maximum entre 6 et 4 : {0}", Math.Max(6, 4));
            Console.WriteLine("minimum entre 6 et 4 : {0}", Math.Min(6, 4));
            Console.WriteLine("maximum entre 6, 4 et 5 : {0}", Math.Max(Math.Max(6, 4), 5)); //on peut faire mieux avec LINQ et les collections

            Console.WriteLine();

            //signes et valeurs absolues
            Console.WriteLine("valeur absolue de -4,567 : {0}", Math.Abs(-4.567));
            Console.WriteLine("signe de -4.567 : {0}", Math.Sign(-4.567));

            Console.WriteLine();

            //racines carrées, puissances, exponentielles et logarithmes
            Console.WriteLine("Racine carrée de 625 : {0}", Math.Sqrt(625));
            Console.WriteLine("8 à la puissance 3 : {0}", Math.Pow(8, 3));
            Console.WriteLine("exponentielle de 1 (Exp(1)) : {0}", Math.Exp(1));
            Console.WriteLine("logarithme népérien de e (ln(e)) : {0}", Math.Log(Math.E));
            Console.WriteLine("logarithme décimal de 10 (log(10)) : {0}", Math.Log10(10));

            Console.WriteLine();

            //trigonométrie
            Console.WriteLine("sin(pi/2) : {0}", Math.Sin(Math.PI / 2));
            Console.WriteLine("cos(pi/2) : {0}", Math.Cos(Math.PI / 2));
            Console.WriteLine("tan(pi/2) : {0}", Math.Tan(Math.PI / 2));
            //il existe aussi : le sinus hyperbolique (Sinh), le cosinus hyperbolique (Cosh), la tangente hyperbolique (Tanh)
            //                  arcsinus (Asin), arccosinus (Acos) et arctan (Atan)

            Console.WriteLine();

            //autres exemples :
            Console.WriteLine("exp(e) = {0}", Math.Exp(Math.E));
            Console.WriteLine("ln(exp(1)) = {0}", Math.Log(Math.Exp(1)));
            Console.WriteLine("sqrt(|cos(1)|) = {0}", Math.Sqrt(Math.Abs(Math.Cos(1))));

            Console.WriteLine();

            //L'assemblage System.Numerics.dll introduit également deux nouvelles classes :
            // BigInteger : un très grand entier sans perte de précision
            // Complex : une structure représentant un nombre complexe
            System.Numerics.BigInteger carlos = System.Numerics.BigInteger.Pow(2, 200);
            Console.WriteLine("2 à la puissance 200 :\n{0}", carlos);

            System.Numerics.Complex complex = new System.Numerics.Complex(2, 3);
            System.Numerics.Complex complex2 = new System.Numerics.Complex(-5, 2);
            Console.WriteLine("Partie réelle de complex : {0} / partie imaginaire de complex : {1}", complex.Real, complex.Imaginary);
            //les opérateurs sont réécrits pour les nombres complexes
            System.Numerics.Complex complex3 = complex + complex2;
            Console.WriteLine("(2 + 3i) + (-5 + 2i) = ({0} + {1}i)", complex3.Real, complex3.Imaginary);
            complex3 = System.Numerics.Complex.Conjugate(complex);
            Console.WriteLine("conjugué de (2 + 3i) = ({0} + {1}i)", complex3.Real, complex3.Imaginary);
        }
    }
}
