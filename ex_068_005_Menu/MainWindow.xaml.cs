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

namespace ex_068_005_Menu
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

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            mTextBlock.Text = string.Format("Vous avez cliqué sur {0}", (sender as MenuItem).Header.ToString().Replace("_", ""));
        }

        private void MenuItem_Checked_1(object sender, RoutedEventArgs e)
        {
            if ((sender as MenuItem).IsChecked)
            {
                mTextBlock.Foreground = Brushes.Blue;
            }
            else
            {
                mTextBlock.Foreground = Brushes.Black;
            }
        }
    }
}
