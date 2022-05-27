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

// le point d'entrée d'une application Console est la fonction Main (statique) d'une classe quelconque 
// que Visual Studio nomme par défaut Program, et qu'il place automatiquement dans l'espace de noms
// portant  le même nom que le projet. Vous pouvez changer le nom de la classe et l'espace de noms.
namespace ex_003_001_Main
{
    class Program
    {
        /// <summary>
        /// En C#, tous les objets dérivent de la classe object, et tout est objet.
        /// En conséquence, la fonction Main doit être dans une classe (ici la classe Program).
        /// La fonction Main est le point d'entrée du programme. Elle est statique pour pouvoir
        /// être appelée sans que Program soit instancié. Ce n'est pas important si ceci n'est pas 
        /// encore clair pour vous, à ce moment-là du cours.
        /// </summary>
        static void Main()
        {
        }
    }
}
