// ========================================================================
//
// Copyright (C) 2013-2014 MARC CHEVALDONNE
//                         marc.chevaldonne.free.fr
//
// Module        : Program.cs
// Author        : Marc Chevaldonné
// Creation date : 2014-05-26
//
// ========================================================================

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Reflection;
using Animal;

namespace Reflection
{
    class Program
    {
        static void Main(string[] args)
        {
            //permet d'accéder au dossier courant (ici l'endroit où se trouve l'exécutable)
            Console.WriteLine(System.IO.Directory.GetCurrentDirectory());

            DirectoryInfo folder = new DirectoryInfo(Directory.GetParent(Directory.GetCurrentDirectory().ToString()).ToString()+"\\plugin\\");
            FileInfo[] files = folder.GetFiles();

            foreach (FileInfo file in files)
            {
                if (file.Extension == ".dll")
                {
                    AnalyseDLL(file.FullName);
                }
            }

            
        }

        static void AnalyseDLL(string filePath)
        {
            //chargement d'une dll dans ce dossier courant
            Assembly a = Assembly.LoadFile(filePath);

            //on récupère tous les types contenus dans cette dll dans un tableau "types"
            Type[] types = a.GetExportedTypes();

            //pour chacun de ces types :
            foreach (Type t in types)
            {
                //on écrit le nom du type (nom d'une classe par exemple)
                Console.Write(t.Name);

                //boucle de parcours des types de base afin de voir si le type dérive de Mammifère ou non
                Type t_temp = t;
                while (t_temp.BaseType != Type.GetType("System.Object", false, true)
                    && t_temp.BaseType.FullName != "Animal.Mammifère")
                {
                    t_temp = t_temp.BaseType;
                }
                if (t_temp.BaseType.FullName == "Animal.Mammifère")
                {
                    //si le type dérive de Mammifère, on écrit le nom du type Mammifère entre parenthèses
                    Console.Write(" (" + t_temp.BaseType.Name + ")\n");

                    //on appelle le constructeur du type (chat ou chien par exemple) et on le référence à l'aide d'une
                    //référence sur un Mammifère (chat et chien dérivent de mammifère)
                    Mammifère bitxo = Activator.CreateInstance(t) as Mammifère;

                    //on affiche à l'écran le membre mName du type concerné (minou pour chat, toutou pour chien)
                    Console.WriteLine("      je m'appelle : " + bitxo.Name);
                }
                else
                {
                    //si le type ne dérive pas de Mammifère, alors on le dit
                    Console.WriteLine(" ne dérive pas de Animal.Mammifère");
                }
                Console.WriteLine();
            }
        }
    }
}
