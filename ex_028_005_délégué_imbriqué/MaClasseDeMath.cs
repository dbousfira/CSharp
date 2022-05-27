// ========================================================================
//
// Copyright (C) 2013-2014 MARC CHEVALDONNE
//                         marc.chevaldonne.free.fr
//
// Module        : MaClasseDeMath.cs
// Author        : Marc Chevaldonné
// Creation date : 2014-04-27
//
// ========================================================================

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Namespace2
{
    /// <summary>
    /// une classe qui réalise quelques opérations mathématiques
    /// </summary>
    public class MaClasseDeMath
    {
        /// <summary>
        /// on définit le délégué ici dans la classe MaClasseDeMath avec la visibilité qui nous intéresse (ici j'ai choisi internal)
        /// </summary>
        /// <param name="x">un entier</param>
        /// <returns>un autre entier dépendant du paramètre et de l'exécution de la fonction de type Modifieur</returns>
        internal delegate int Modifieur(int x);

        /// <summary>
        /// méthode static calculant a^b
        /// Cette méthode n'est pas de type "Modifieur" car elle n'a pas la même signature que le délégué
        /// </summary>
        /// <param name="a">l'entier a élévé à la puissance b</param>
        /// <param name="b">l'exposant</param>
        /// <returns>a^b</returns>
        public static int Power(int a, int b)
        {
            return (int)Math.Pow(a, b);
        }

        /// <summary>
        /// méthode calculant le carré d'un entier
        /// Cette méthode est du type "Modifieur" car sa signature est la même que celle du délégué
        /// </summary>
        /// <param name="a">entier élevé au carré</param>
        /// <returns>a^2</returns>
        public static int Carré(int a)
        {
            return a * a;
        }

        /// <summary>
        /// méthode calculant le cube d'un entier
        /// Cette méthode est du type "Modifieur" car sa signature est la même que celle du délégué
        /// </summary>
        /// <param name="a">entier élevé au cube</param>
        /// <returns>a^3</returns>
        public static int Cube(int a)
        {
            return a * a * a;
        }
    }
}

