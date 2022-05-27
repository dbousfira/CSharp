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

namespace ex_004_001_TypesNumeriques
{
    class Program
    {
        /// <summary>
        /// Dans cet exemple, plusieurs variables de différents types sont présentées. Notez qu'un constante
        /// de type float nécessite un f pour être différenciée d'un double
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            //types entiers
            byte b; //variable codée sur un octet (n'importe quelle valeur entre 0 et 255)
            sbyte sb; //variable codée sur un octet mais signée (n'importe quelle valeur entre -128 et 127)
            short sh; //entier signé sur 16 bits. de -32768 à 32767 (automatiquement converti en int pendant une opération arithmétique)
            ushort ush; //idem short, mais non signé : de 0 à 65535
            int i; //entier codé sur 32 bits.
            i = 10;
            uint ui; //entier non signé codé sur 32 bits.
            long l; //entier signé codé sur 64 bits.
            l = 10L;
            ulong ul; //entier non signé codé sur 64 bits.

            //types réels
            float f; //codé sur 32 bits
            f = 4.5f;
            double d; //codé sur 64 bits
            d = 4.5;
            decimal dec; //codé sur 128 bits, spécialement créé pour les applications financières. Plus précis mais 10 fois plus lent.
            dec = 1.2m;

            //le qualificatif const permet de garantir qu'une "variable" ne sera pas modifiée
            const int ci = 3;

            //membres des types numériques
            Console.WriteLine("int.MinValue = {0}", int.MinValue);
            Console.WriteLine("int.MaxValue = {0}", int.MaxValue);
            Console.WriteLine("float.MinValue = {0}", float.MinValue);
            Console.WriteLine("float.MaxValue = {0}", float.MaxValue);
            Console.WriteLine("float.Epsilon = {0}", float.Epsilon);
            Console.WriteLine("float.NegativeInfinity = {0}", float.NegativeInfinity);
            Console.WriteLine("float.PositiveInfinity = {0}", float.PositiveInfinity);

            //valeurs par défaut :
            //numerique : 0
        }
    }
}
