// ========================================================================
//
// Copyright (C) 2013-2014 MARC CHEVALDONNE
//                         marc.chevaldonne.free.fr
//
// Module        : MonLit.cs
// Author        : Marc Chevaldonné
// Creation date : 2014-03-30
//
// ========================================================================

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_023_016_IEnumerableOfInterfaces
{
    class MonLit
    {
        //on veut encapsuler une collection d'un type muable
        private List<Nounours> mNounours = new List<Nounours>(new Nounours[] { 
                                    new Nounours(1, "Beluga", new DateTime(2012, 07, 29), 0),
                                    new Nounours(2, "Singe", new DateTime(2009, 08, 09), 1345),
                                    new Nounours(3, "Girafe", new DateTime(2007, 11, 02), 567)});

        //ceci est nul : ce n'est pas du tout une encapsulation
        public List<Nounours> NounoursList
        {
            get
            {
                return mNounours;
            }
            private set
            {
                mNounours = value;
            }
        }

        // c'est mieux mais pas suffisant...
        public IEnumerable<Nounours> NounoursIEnumerable
        {
            get
            {
                return mNounours;
            }
        }

        //pas suffisant
        //NounoursROC[i].NbPoils = 0;
        public System.Collections.ObjectModel.ReadOnlyCollection<Nounours> NounoursROC
        {
            get;
            private set;
        }

        //OK si Nounours reste internal à la bibliothèque et INounours public en façade immuable
        public IEnumerable<INounours> MesNounours
        {
            get
            {
                return mNounours;
            }
        }

        public MonLit()
        {
            NounoursROC = new System.Collections.ObjectModel.ReadOnlyCollection<Nounours>(mNounours);
        }
    }
}
