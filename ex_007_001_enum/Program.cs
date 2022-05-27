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

namespace ex_007_001_enum
{
    class Program
    {
        /// <summary>
        /// voici une énumération.
        /// public n'est pas obligatoire. S'il est indiqué, l'énumération est utilisable en dehors de la classe.
        /// </summary>
        [Flags]//pas obligatoire mais conseillé pour améliorer le ToString de l'enum dans le cas des combinaisons
        public enum MusicType : byte
        {
            Classic = 1,            //00000001
            Jazz = 2,               //00000010
            Pop = 4,                //00000100
            Rock = 8,               //00001000
            //on peut rajouter des combinaisons d'enum : ici, PopRock est à la fois Pop et Rock
            //il faut pour cela que toutes les valeurs d'enum puissent s'exclure mutuellement
            PopRock = Pop | Rock    //00001100
        }

        static void Main(string[] args)
        {
            //déclaration d'une variable de type MusicType
            MusicType mMuzik;
            //affectation d'une valeur possible à cette variable
            mMuzik =  MusicType.Jazz;
            Console.WriteLine(mMuzik);

            //un exemple d'utilisation
            Console.Write("la variable mMuzik est de type : ");
            switch (mMuzik)
            {
                case MusicType.Classic:
                    Console.WriteLine("Classique"); break;
                case MusicType.Jazz:
                    Console.WriteLine("Jazz"); break;
                case MusicType.Pop:
                    Console.WriteLine("Pop"); break;
                case MusicType.Rock:
                    Console.WriteLine("Rock"); break;
            }
            Console.WriteLine();

            //un enum peut être considéré comme un instance de la classe Enum
            //exemple d'utilisation
            Console.WriteLine("liste des valeurs de l'énumération");
            foreach (string s in Enum.GetNames(typeof(MusicType)))
                Console.WriteLine(s);
            Console.WriteLine();

            //autre utilisation
            Console.Write("la variable mMuzik est de type : ");
            switch (mMuzik)
            {
                case MusicType.Classic:
                    Console.WriteLine(MusicType.Classic.ToString()); break;
                case MusicType.Jazz:
                    Console.WriteLine(MusicType.Jazz.ToString()); break;
                case MusicType.Pop:
                    Console.WriteLine(MusicType.Pop.ToString()); break;
                case MusicType.Rock:
                    Console.WriteLine(MusicType.Rock.ToString()); break;
            }
            Console.WriteLine();

            //combinaison
            mMuzik = MusicType.Jazz | MusicType.Rock; // 00001010
            Console.WriteLine(mMuzik); //si vous utilisez [Flags], affiche "Jazz, Rock", sinon, affiche "10"
            //on veut vérifier que mMuzik est du Jazz :
            if ((mMuzik & MusicType.Jazz) != 0) //mMuzik & Jazz = 00001010 & 00000010 = 00000010 != 0 c'est donc du jazz (entre autres)
            {
                Console.WriteLine("Includes Jazz");
            }
            //on veut vérifier que mMuzik n'est pas de la Pop :
            if ((mMuzik & MusicType.Pop) == 0) //mMuzik & Pop = 00001010 & 00000100 = 00000000 == 0 ce n'est donc pas de la Pop
            {
                Console.WriteLine("pas pop");
            }
            //finalement on veut rajouter Pop
            mMuzik |= MusicType.Pop; //00001010 | 00000100 = 00001110
            if ((mMuzik & MusicType.Pop) != 0) //mMuzik & Pop = 00001110 & 00000100 = 00000100 != 0 c'est donc de la Pop
            {
                Console.WriteLine("pop");
            }
            //et enlever Jazz
            mMuzik ^= MusicType.Jazz; //00001110 ^ 00000010 = 00001100
            if ((mMuzik & MusicType.Jazz) == 0) //mMuzik & Jazz = 00001100 & 00000010 = 00000000 == 0 ce n'est donc plus du jazz
            {
                Console.WriteLine("pas jazz");
            }
        }
    }
}
