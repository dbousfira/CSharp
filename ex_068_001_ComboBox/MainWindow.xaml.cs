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

namespace ex_068_001_ComboBox
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            var nounours = new List<Nounours>()
            {new Nounours("Babar", new DateTime(1931, 1, 1), 34, "babar.gif"),
            new Nounours("Chucky", new DateTime(1988, 11, 9), 66, "chucky.jpg"),
            new Nounours("Gizmo", new DateTime(1984, 6, 8), 1000000, "gizmo.png")
            };

            mComboBox2.ItemsSource = nounours;
            mComboBox3.ItemsSource = nounours;
        }

        private void mComboBox3_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {
            mTextBlockSelectionChanged.Text = string.Format("Vous avez sélectionné {0}", ((sender as ComboBox).SelectedItem as Nounours).Nom);
        }
    }
}
