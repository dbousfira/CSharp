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

namespace ex_014_002_typesImbriques
{
    public class UneClasse
    {
        class UneClasseImbriquéePrivée
        {
        }

        private UneClasseImbriquéePrivée mMembre1;

        //public UneClasseImbriquéePrivée mMembre2; //on ne peut pas avoir de membre autre que public de ce type, car la classe imbriquée est privée
        //elle n'est donc pas visible en dehors de la classe UneClasse


        public class UneClasseImbriquéePublique
        {
        }

        private UneClasseImbriquéePublique mMembre3;
        public UneClasseImbriquéePublique mMembre4;

        public enum UnEnumImbriqué
        {
            Inconnu,
            Connu
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            UneClasse uneClasse = new UneClasse();
            var qqchse = uneClasse.mMembre4;

            UneClasse.UnEnumImbriqué variable = UneClasse.UnEnumImbriqué.Connu;
        }
    }
}
