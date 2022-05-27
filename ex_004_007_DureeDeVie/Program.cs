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


namespace ex_004_007_DureeDeVie
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 2;//la pile contient ... a

            int b = 3;//la pile contient ... a b

            float f = 10;//la pile contient ... a b f

            {
                int c = a + b; //la pile contient ... a b f c
                f /= c; //f est modifié, la pile contient ... a b f c
            }//c meurt ici, la pile contient ... a b f

            TimeSpan ts = TimeSpan.FromHours(2); //la pile contient ... a b f ts

            {
                TimeSpan ts2 = ts - TimeSpan.FromHours(1); //la pile contient ... a b f ts ts2
            }//ts2 meurt ici, la pile contient ... a b f ts 


        }//a, b, f, ts meurent ici, la pile contient ...
    }
}
