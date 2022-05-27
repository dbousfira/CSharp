// ========================================================================
//
// Copyright (C) 2013-2014 MARC CHEVALDONNE
//                         marc.chevaldonne.free.fr
//
// Module        : GrosTravail.cs
// Author        : Marc Chevaldonné
// Creation date : 2014-04-13
//
// ========================================================================

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nsUtils
{
    /// <summary>
    /// une classe qui fait un gros travail ...
    /// </summary>
    public class ClasseQuiFaitDuGrosTravail
    {
        /// <summary>
        /// on définit le délégué ici dans le namespace nsUtils avec la visibilité qui nous intéresse (ici j'ai choisi public)
        /// </summary>
        /// <param name="pourcentage">un entier</param>
        public delegate void Progression(int pourcentage);

        /// <summary>
        /// instance de délégué
        /// </summary>
        private Progression InstanceProgression;

        public void Initialiser(Progression prog)
        {
            InstanceProgression = prog;
        }

        public void Attacher(Progression prog)
        {
            InstanceProgression += prog;
        }

        public void Détacher(Progression prog)
        {
            InstanceProgression -= prog;
        }

        /// <summary>
        /// méthode statique qui appelle les méthodes pointées par la méthode p de type délégué Progression toutes les demi-secondes
        /// </summary>
        /// <param name="p">instance de délégué de type délégué "Progression" qui sera appelée à chaque dem-seconde</param>
        public void GrosTravail()
        {
            for (int i = 0; i <= 100; i++)
            {
                //exécution de l'instance de délégué
                if (InstanceProgression != null)
                {
                    InstanceProgression(i);
                }
                System.Threading.Thread.Sleep(50);
            }
        }
    }
}
