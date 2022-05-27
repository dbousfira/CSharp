// ========================================================================
//
// Copyright (C) 2013-2014 MARC CHEVALDONNE
//                         marc.chevaldonne.free.fr
//
// Module        : Program.cs
// Author        : Marc Chevaldonné
// Creation date : 2014-05-17
//
// ========================================================================

using System;
using System.Windows;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_065_003_Explicit
{
    class Program
    {
        [STAThread]
        static void Main()
        {
            Application app = new Application();
            MainWindow window = new MainWindow();
            window.Show();
            app.Run();
        }
    }
}
