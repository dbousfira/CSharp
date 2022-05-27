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

using System.Diagnostics;

namespace ex_025_001_DebugTrace
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 2;
            int b = 3;
            int c = -4;

            int d = a + b;
            //la ligne suivante ne sera gardée à la compilation que si le symbole DEBUG est défini.
            DisplayMessage("d vaut " + d);

            //les lignes suivantes sont exécutées si le symbole DEBUG est défini (par défaut en mode Debug)
            //et le contenu est affiché dans la fenêtre de Sortie
            //(généralement en bas de l'écran)
            Debug.WriteLine("d vaut " + d);
            Debug.WriteLineIf(d > c, "d est supérieur à c");

            int e = d * c;
            //les lignes suivantes sont exécutées si le symbole TRACE est défini (par défaut en mode Debug et Release)
            //et le contenu est généralement affiché en bas de l'écran dans la fenêtre de Sortie
            Trace.TraceInformation("e = " + e);
            Trace.TraceWarning("e vaut : " + e);

            //le texte est affiché dans la fenêtre de sortie, si et seulement si le symbole DEBUG est défini et si la condition "e>0" est vraie
            //Debug.Assert(e > 0, "e est négatif !");

            //dans les lignes suivantes, nous demandons à la classe Trace de ne plus écrire dans la fenêtre de Sortie...
            Trace.Listeners.Clear();
            //...on lui définit un nouveau TraceListener qui sera la fenêtre Console...
            System.IO.TextWriter tw = Console.Out;
            Trace.Listeners.Add(new TextWriterTraceListener(tw));
            //...les messages de Trace sont donc maintenant envoyés dans la Console
            Trace.Assert(e > 0, "e est négatif !");
            if (e < 0)
            {
                Trace.Fail("e est négatif");
            }

        }

        /// <summary>
        /// cette méthode et les appels de cette méthode ne seront gardés à la compilation, que si le symbole DEBUG est défini.
        /// Le symbole DEBUG est défini par défaut en mode ... Debug
        /// </summary>
        /// <param name="message"></param>
        [Conditional("DEBUG")]
        static void DisplayMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}
