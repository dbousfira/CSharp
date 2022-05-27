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

namespace ex_004_005_TypeChar
{
    class Program
    {
        static void Main(string[] args)
        {
            //type char
            char c; //codé sur 16 bits ( != du C++ ), caractère du système Unicode
            c = 'A';
            c = '\x41'; //0x41 (ou 65 en décimal) dans Unicode. lettre A
            c = (char)65; //idem
            c = '\u0041'; //idem
            //quelques caractères utiles
            c = '\n'; //à la ligne
            c = '\t'; //tabulation horizontale
            c = '\v'; //tabulation verticale
            c = '\\'; //backslash
            c = '\''; //single quote
            c = '\"'; //double quote
            c = '\0'; //null

            //quelques membres du type char :
            char a = 'A';
            char deux = '2';
            char virgule = ',';
            char blanc = ' ';
            //IsDigit : le caractère est-il un chiffre ?
            Console.WriteLine("char.IsDigit('A') ? {0}", char.IsDigit(a));
            Console.WriteLine("char.IsDigit('2') ? {0}", char.IsDigit(deux));
            Console.WriteLine("char.IsDigit(',') ? {0}", char.IsDigit(virgule));
            Console.WriteLine("char.IsDigit(' ') ? {0}", char.IsDigit(blanc));
            Console.WriteLine();
            //IsLetter indique s'il s'agit d'une lettre
            Console.WriteLine("char.IsLetter('A') ? {0}", char.IsLetter(a));
            Console.WriteLine("char.IsLetter('2') ? {0}", char.IsLetter(deux));
            Console.WriteLine("char.IsLetter(',') ? {0}", char.IsLetter(virgule));
            Console.WriteLine("char.IsLetter(' ') ? {0}", char.IsLetter(blanc));
            //il y a aussi IsLower pour les minuscules,  IsUpper pour les majuscules, IsLetterOrDigit pour lettres ou nombres
            Console.WriteLine();

            //IsPunctuation indique s'il s'agit d'un caractère de ponctuation
            Console.WriteLine("char.IsPunctuation('A') ? {0}", char.IsPunctuation(a));
            Console.WriteLine("char.IsPunctuation('2') ? {0}", char.IsPunctuation(deux));
            Console.WriteLine("char.IsPunctuation(',') ? {0}", char.IsPunctuation(virgule));
            Console.WriteLine("char.IsPunctuation(' ') ? {0}", char.IsPunctuation(blanc));
            Console.WriteLine();

            //IsWhiteSpace indique s'il s'agit d'un blanc
            Console.WriteLine("char.IsWhiteSpace('A') ? {0}", char.IsWhiteSpace(a));
            Console.WriteLine("char.IsWhiteSpace('2') ? {0}", char.IsWhiteSpace(deux));
            Console.WriteLine("char.IsWhiteSpace(',') ? {0}", char.IsWhiteSpace(virgule));
            Console.WriteLine("char.IsWhiteSpace(' ') ? {0}", char.IsWhiteSpace(blanc));
            Console.WriteLine();

            //ToUpper et ToLower convertisse en majuscules ou en minuscules.
            Console.WriteLine("char.ToLower('A') = {0}", char.ToLower('A'));
            Console.WriteLine("char.ToUpper('a') = {0}", char.ToUpper('a'));
            Console.WriteLine("char.ToUpper('é') = {0}", char.ToUpper('é'));
        }
    }
}
