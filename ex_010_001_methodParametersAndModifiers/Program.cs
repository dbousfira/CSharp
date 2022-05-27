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

namespace ex_010_001_methodParametersAndModifiers
{
    class ExFunct
    {
        //passage d'arguments par valeur
        public int Somme(int a, int b)
        {
            int result = a + b;
            //celui qui appelle cette méthode ne pourra pas voir ces changements
            //car a et b sont ici des copies locales des paramètres qu'il a passés
            a++;
            b++;
            return result;
        }

        //passage d'argument par référence (notez le mot-clé ref)
        public int SommeRef(ref int a, ref int b)
        {
            int result = a + b;
            //celui qui appelle cette méthode verra les deux paramètres qu'il a passés
            //modifiés par celle-ci, car ils sont passés par référence
            a++;
            b++;
            return result;
        }

        //passage de tableaux en argument (pas besoin de préciser ref, le tableau en est une)
        public int SommeTab(int[] tab)
        {
            int result = 0;
            for (int i = 0; i < tab.Length; i++)
            {
                //celui qui appelle cette méthode verra les valeurs du tableau passé en paramètre
                //modifiées par la méthode, car un tableau est toujours passé par référence
                //(un tableau EST un type REFERENCE)
                result += tab[i];
                tab[i]++;
            }
            return result;
        }

        //passage d'argument out : indique que la variable est initialisée par la fonction appelée (notez le mot-clé out)
        public void SommeOut(int a, int b, out int result)
        {
            //celui qui appelle cette méthode peut donner result sans l'initialiser
            //le mot-clé out garantit que ce paramètre sera initialisé dans la méthode
            result = a + b;
        }

        //passage d'arguments en nombre indéterminé, en dernier paramètre de la méthode uniquement
        public int SommeParams(params int[] ints)
        {
            //l'utilisateur de la méthode n'a pas besoin de préciser params
            //en revanche, il peut passer autant d'arguments de type int qu'il le souhaite.
            //À l'intérieur de la méthode, ces arguments sont traités comme un tableau d'entiers,
            //mais tous les éléments de ce tableau sont copiés par valeur.
            int result = 0;
            for(int i = 0; i<ints.Length; i++)
            {
                result += ints[i];
                ints[i]++;
            }
            return result;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            ExFunct f = new ExFunct();
            int a = 2;
            int b = 3;
            Console.WriteLine("f.Somme(a, b)");
            Console.WriteLine("a (avant) = " + a);
            Console.WriteLine("b (avant) = " + b);
            Console.WriteLine("résultat : " + f.Somme(a, b)); //passage d'arguments par valeur
            Console.WriteLine("a (après) = " + a);
            Console.WriteLine("b (après) = " + b);
            Console.WriteLine();

            Console.WriteLine("f.SommeRef(ref a, ref b)");
            Console.WriteLine("a (avant) = " + a);
            Console.WriteLine("b (avant) = " + b);
            Console.WriteLine("résultat : " + f.SommeRef(ref a, ref b));//passage d'argument par référence (notez le mot clé ref) --> a est modifié par la fonction
            Console.WriteLine("a (après) = " + a);
            Console.WriteLine("b (après) = " + b);
            Console.WriteLine();

            Console.WriteLine("tableaux");
            int[] t = { 1, 2, 3 };
            Console.Write("tableau t (avant) : ");
            foreach (int i in t) Console.Write(i + " ");
            Console.WriteLine();
            f.SommeTab(t); //passage de tableau en argument (pas besoin de ref, car c'est est une).
            Console.WriteLine("f.SommeTab(t);");
            Console.Write("tableau t (après) : ");
            foreach (int i in t) Console.Write(i + " ");
            Console.WriteLine();
            Console.WriteLine();

            int c;
            Console.WriteLine("f.SommeOut(a, b, out c);");
            Console.WriteLine("a (avant) = " + a);
            Console.WriteLine("b (avant) = " + b);
            Console.WriteLine("c est non assigné");
            f.SommeOut(a, b, out c);
            Console.WriteLine("résultat : " + c); //passage d'argument out. c n'est pas initialisé, et on utilise le mot clé out
            Console.WriteLine("a (après) = " + a);
            Console.WriteLine("b (après) = " + b);
            Console.WriteLine("c (après) = " + c);
            Console.WriteLine();

            Console.WriteLine("f.SommeParams(a, b, c)");
            Console.WriteLine("a (avant) = " + a);
            Console.WriteLine("b (avant) = " + b);
            Console.WriteLine("c (avant) = " + c);
            //passage d'arguments en nombre indéterminé
            Console.WriteLine("résultat : " + f.SommeParams(a, b, c));
            Console.WriteLine("a (après) = " + a);
            Console.WriteLine("b (après) = " + b);
            Console.WriteLine("c (après) = " + c);
            Console.WriteLine();
        }
    }
}
