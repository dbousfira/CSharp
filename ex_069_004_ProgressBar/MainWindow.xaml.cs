// ========================================================================
//
// Copyright (C) 2013-2014 MARC CHEVALDONNE
//                         marc.chevaldonne.free.fr
//
// Module        : MainWindow.xaml.cs
// Author        : Marc Chevaldonné
// Creation date : 2014-05-17
//
// ========================================================================

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace ex_069_004_ProgressBar
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        DispatcherTimer dt = new DispatcherTimer();

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            dt.Tick += dt_Tick;
            dt.Interval = TimeSpan.FromMilliseconds(20);
            dt.Start();
        }

        void dt_Tick(object sender, EventArgs e)
        {
            mProgressBar.Value++;
            if (mProgressBar.Value == mProgressBar.Maximum)
            {
                dt.Stop();
            }
        }
    }
}
