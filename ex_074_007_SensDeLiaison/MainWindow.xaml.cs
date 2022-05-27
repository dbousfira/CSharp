// ========================================================================
//
// Copyright (C) 2013-2014 MARC CHEVALDONNE
//                         marc.chevaldonne.free.fr
//
// Module        : MainWindow.xaml.cs
// Author        : Marc Chevaldonné
// Creation date : 2014-05-26
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

namespace ex_074_007_SensDeLiaison
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            //mGrid.DataContext = new Nounours("Babar", new DateTime(1931, 1, 1), 34);  
        }

        private void mButtonOK_Click(object sender, RoutedEventArgs e)
        {
            (mGrid.DataContext as Nounours).Nom = "Chucky";
            (mGrid.DataContext as Nounours).DateDeNaissance = new DateTime(1988, 11, 9);
            (mGrid.DataContext as Nounours).NbPoils = 66;
        }

        private void mButtonGizmo_Click(object sender, RoutedEventArgs e)
        {
            mGrid.DataContext = new Nounours("Gizmo", new DateTime(1984, 6, 8), 356937596);
        }

        private void mButtonSendToSource_Click(object sender, RoutedEventArgs e)
        {
            BindingExpression[] bes = {this.mOneWayToSourceNom.GetBindingExpression(TextBox.TextProperty),
                                       this.mOneWayToSourceNaissance.GetBindingExpression(TextBox.TextProperty),
                                       this.mOneWayToSourceNbPoils.GetBindingExpression(TextBox.TextProperty)};
            bes.ToList().ForEach(be => be.UpdateSource());
        }
    }
}
