// ========================================================================
//
// Copyright (C) 2013-2014 MARC CHEVALDONNE
//                         marc.chevaldonne.free.fr
//
// Module        : Program.cs
// Author        : Marc Chevaldonné
// Creation date : 2014-04-13
//
// ========================================================================

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_031_001_decouverteDeLINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            AfficheNounours();
            Console.WriteLine(string.Empty.PadLeft(Console.WindowWidth - 1, '*'));
            AfficheNounours2();
            Console.WriteLine(string.Empty.PadLeft(Console.WindowWidth - 1, '*'));
            AfficheNounours3();
            Console.WriteLine(string.Empty.PadLeft(Console.WindowWidth - 1, '*'));
            AfficheNounours4();
            Console.WriteLine(string.Empty.PadLeft(Console.WindowWidth - 1, '*'));
            AfficheNounours5(nounours => nounours.NbPoils > 0);
            Console.WriteLine(string.Empty.PadLeft(Console.WindowWidth - 1, '*'));
            AfficheNounours6(nounours => nounours.NbPoils > 0);
            Console.WriteLine(string.Empty.PadLeft(Console.WindowWidth - 1, '*'));
            AfficheNounours7(nounours => nounours.NbPoils > 0);
            Console.WriteLine(string.Empty.PadLeft(Console.WindowWidth - 1, '*'));
            AfficheNounours8(nounours => nounours.NbPoils > 0);
        }

        /// <summary>
        /// un exemple classique de traitement de collection
        /// </summary>
        static void AfficheNounours()
        {
            List<string> nounours = new List<string>();
            foreach (Nounours n in Nounours.TousMesNounours)
            {
                if (n.NbPoils > 0)
                {
                    nounours.Add(n.Nom);
                }
            }

            // plus loin ou ailleurs...
            foreach (string s in nounours)
            {
                Console.WriteLine(s);
            }
        }

        class NounoursData
        {
            public string Nom
            {
                get;
                set;
            }

            public int AnnéeNaissance
            {
                get;
                set;
            }

            public int NbPoils
            {
                get;
                set;
            }

            public override string ToString()
            {
                return string.Format("Nom = {0}\tAnnéeNaissance = {1}\tNbPoils = {2}", Nom, AnnéeNaissance, NbPoils);
            }
        }

        /// <summary>
        /// un exemple classique de traitement de collection
        /// </summary>
        static void AfficheNounours2()
        {
            List<NounoursData> nounoursDatas = new List<NounoursData>();
            foreach (Nounours nounours in Nounours.TousMesNounours)
            {
                if (nounours.NbPoils > 0)
                {
                    NounoursData data = new NounoursData();
                    data.Nom = nounours.Nom;
                    data.AnnéeNaissance = nounours.Naissance.Year;
                    data.NbPoils = nounours.NbPoils;
                    nounoursDatas.Add(data);
                }
            }

            foreach (NounoursData data in nounoursDatas)
            {
                Console.WriteLine(data);
            }
        }

        /// <summary>
        /// utilisation de var (variable implicitement typée)
        /// </summary>
        static void AfficheNounours3()
        {
            var nounoursDatas = new List<NounoursData>();
            foreach (var nounours in Nounours.TousMesNounours)
            {
                if (nounours.NbPoils > 0)
                {
                    var data = new NounoursData();
                    data.Nom = nounours.Nom;
                    data.AnnéeNaissance = nounours.Naissance.Year;
                    data.NbPoils = nounours.NbPoils;
                    nounoursDatas.Add(data);
                }
            }

            foreach (var data in nounoursDatas)
            {
                Console.WriteLine(data);
            }
        }

        /// <summary>
        /// utilisation des initializers 
        /// </summary>
        static void AfficheNounours4()
        {
            var nounoursDatas = new List<NounoursData>();
            foreach (var nounours in Nounours.TousMesNounours)
            {
                if (nounours.NbPoils > 0)
                {
                    nounoursDatas.Add(new NounoursData
                    {
                        Nom = nounours.Nom,
                        AnnéeNaissance = nounours.Naissance.Year,
                        NbPoils = nounours.NbPoils
                    });
                }
            }

            foreach (var data in nounoursDatas)
            {
                Console.WriteLine(data);
            }
        }

        /// <summary>
        /// expression lambda
        /// </summary>
        /// <param name="sélection"></param>
        static void AfficheNounours5(Predicate<Nounours> sélection)
        {
            var nounoursDatas = new List<NounoursData>();
            foreach (var nounours in Nounours.TousMesNounours)
            {
                if (sélection(nounours))
                {
                    nounoursDatas.Add(new NounoursData
                    {
                        Nom = nounours.Nom,
                        AnnéeNaissance = nounours.Naissance.Year,
                        NbPoils = nounours.NbPoils
                    });
                }
            }

            foreach (var data in nounoursDatas)
            {
                Console.WriteLine(data);
            }
        }

        /// <summary>
        /// méthode d'extensions
        /// </summary>
        /// <param name="sélection"></param>
        static void AfficheNounours6(Predicate<Nounours> sélection)
        {
            var nounoursDatas = new List<NounoursData>();
            foreach (var nounours in Nounours.TousMesNounours)
            {
                if (sélection(nounours))
                {
                    nounoursDatas.Add(new NounoursData
                    {
                        Nom = nounours.Nom,
                        AnnéeNaissance = nounours.Naissance.Year,
                        NbPoils = nounours.NbPoils
                    });
                }
            }

            int nbPoils = nounoursDatas.OrderByDescending(nounours => nounours.AnnéeNaissance)
                                       .Take(2)
                                       .Sum(nounours => nounours.NbPoils);

            foreach (var data in nounoursDatas)
            {
                Console.WriteLine(data);
            }
            Console.WriteLine("Les deux nounours les plus jeunes possèdent à eux deux {0} poils", nbPoils);
        }

        /// <summary>
        /// utilisation d'un type anonyme
        /// </summary>
        /// <param name="sélection"></param>
        static void AfficheNounours7(Predicate<Nounours> sélection)
        {
            var nounoursDatas = new List<Object>();
            foreach (var nounours in Nounours.TousMesNounours)
            {
                if (sélection(nounours))
                {
                    nounoursDatas.Add(new
                    {
                        Nom = nounours.Nom,
                        AnnéeNaissance = nounours.Naissance.Year,
                        NbPoils = nounours.NbPoils
                    });
                }
            }

            //int nbPoils = nounoursDatas.OrderByDescending(nounours => nounours.AnnéeNaissance)
            //                           .Take(2)
            //                           .Sum(nounours => nounours.NbPoils);

            foreach (var data in nounoursDatas)
            {
                Console.WriteLine(data);
            }
            //Console.WriteLine("Les deux nounours les plus jeunes possèdent à eux deux {0} poils", nbPoils);
        }

        /// <summary>
        /// LINQ dans toute sa puissance
        /// </summary>
        /// <param name="sélection"></param>
        static void AfficheNounours8(Predicate<Nounours> sélection)
        {
            var nounoursDatas = Nounours.TousMesNounours.Where(nounours => sélection(nounours))
                                                       .Select(nounours => new
                                                       {
                                                           Nom = nounours.Nom,
                                                           AnnéeNaissance = nounours.Naissance.Year,
                                                           NbPoils = nounours.NbPoils
                                                       });

            int nbPoils = nounoursDatas.OrderByDescending(nounours => nounours.AnnéeNaissance)
                                       .Take(2)
                                       .Sum(nounours => nounours.NbPoils);

            foreach (var data in nounoursDatas)
            {
                Console.WriteLine(data);
            }
            Console.WriteLine("Les deux nounours les plus jeunes possèdent à eux deux {0} poils", nbPoils);
        }
    }
}
