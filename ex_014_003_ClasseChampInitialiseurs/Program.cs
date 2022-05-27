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

namespace ex_014_003_ClasseChampInitialiseurs
{
    //la classe est le type de référence le plus commun
    //avant class, on trouve un ou plusieurs modifiers : public, internal, abstract, sealed, static, unsafe, partial
    // public rend cette classe visible et utilisable dans d'autres assemblages
    // internal rend cette classe visible et utilisable dans l'assemblage uniquement
    // les autres seront vus plus tard
    internal class Disque
    {
        //un champ est une variable qui est un membre de cette classe
        //pour respecter le principe d'encapsulation, un champ devrait toujours être privé (modifieur [accesseur] private par défaut) ou protégé (protected)
        //mais un champ peut-être aussi public ou internal
        string mTitre;

        //un champ peut être initialisé dans sa déclaration (on parle d'initialiseur)
        int mNombre = 1;

        //un champ peut être de type valeur...
        int année;

        //... ou de type référence
        Artiste mArtiste;

        //si un champ a un modifier readonly, il ne peut être initialisé que dans sa déclaration (initialiseur) ou dans le constructeur ("run-time constant")
        readonly string mMaisonDeDisque = "IUT";

        //si un champ a un modifier const, il ne peut être initialisé que dans sa déclaration ("compile-time constant")
        const string mTruc = "non rien";

        //object initializers
        //peuvent ainsi être initialisés sans constructeurs 
        //attention : il ne vaut pas mieux mettre des membres en public. Cette méthode est donc surtout utile pour 
        // des propriétés publiques (cf. plus tard)
        public int A
        {
            get;
            set;
        }
        public int B;
        public int C;
    }

    class Artiste
    {
        //rien pour l'instant...
    }

    class Program
    {
        static void Main(string[] args)
        {
            Disque d = new Disque();

            //initializers
            Disque d2 = new Disque { A = 1, B = 2, C = 3 };
            Disque d3 = new Disque() { A = 4, B = 5, C = 6 };
        }
    }
}
